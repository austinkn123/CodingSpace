import React, { useState, useEffect } from 'react';

/**
 * CONCEPT: Generics in TypeScript & React
 * 
 * In C#, you used Generics to create reusable logic for any Type.
 * In TypeScript, we do the exact same thing to ensure type safety 
 * without duplicating code.
 */

interface LabResponse<T> {
  data: T;
  labType: string;
}

// 1. Generic Interface
interface BoxProps<T> {
  content: T;
  label: string;
}

// 2. Generic Component
// This component can display ANY type of content (string, number, object)
function Box<T>({ content, label }: BoxProps<T>) {
  return (
    <div style={{ border: '1px solid #ccc', padding: '10px', margin: '10px' }}>
      <strong>{label}:</strong> {String(content)}
    </div>
  );
}

// 3. Generic Constraints (Mirroring "where T : class")
interface Identifiable {
  id: string;
  name: string;
}

// This function ONLY accepts types that have an id and name
function DisplayEntity<T extends Identifiable>({ entity }: { entity: T }) {
  return (
    <div>
      <p>ID: {entity.id}</p>
      <p>Name: {entity.name}</p>
    </div>
  );
}

const GenericsLab: React.FC = () => {
  const [backendMessage, setBackendMessage] = useState<string>("Waiting for C#...");
  const user = { id: 'u1', name: 'Tony (Architect)', role: 'Senior Mentor' };

  useEffect(() => {
    // CONCEPT: Integrating the Bridge (API)
    // We fetch from our C# Backend running on port 5283
    fetch('http://localhost:5283/api/generics/info')
      .then(res => res.json())
      .then((data: LabResponse<string>) => {
        setBackendMessage(data.data);
      })
      .catch(err => {
        console.error("API Error:", err);
        setBackendMessage("Error: Is the API running?");
      });
  }, []);

  return (
    <div style={{ padding: '20px' }}>
      <h1>React Generics Playground</h1>

      <section style={{ backgroundColor: '#eef', color: '#333' }}>
        <h2>0. The Backend Bridge (API)</h2>
        <p><b>Message from C# Generic Endpoint:</b> {backendMessage}</p>
      </section>
      
      <section>
        <h2>1. Generic Containers (The "Box" Pattern)</h2>
        <Box<number> content={100} label="Number Box" />
        <Box<string> content="Fragile Content" label="String Box" />
      </section>

      <section>
        <h2>2. Generic Constraints (Type Safety)</h2>
        {/* This works because 'user' has id and name */}
        <DisplayEntity entity={user} />
        
        {/* 
            UNCOMMENT TO SEE ERROR: 
            This would fail because 'int' doesn't satisfy 'Identifiable'
            <DisplayEntity entity={42} /> 
        */}
      </section>

      <section style={{ marginTop: '20px', borderTop: '2px solid' }}>
        <h3>Architectural Note</h3>
        <p>
          Just like in C#, Generics in React allow us to build <b>Higher Order Components</b> 
          and reusable UI patterns without losing the "Senior Level" type safety we need for 
          large scale applications.
        </p>
      </section>
    </div>
  );
};

export default GenericsLab;
