import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import GenericsLab from './labs/GenericsLab'

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <h1>CodingSpace Learning Lab</h1>
      </header>
      <main>
        <GenericsLab />
      </main>
    </div>
  )
}

export default App
