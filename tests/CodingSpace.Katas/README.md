# TDD Katas

Standalone exercises for practicing the **Red-Green-Refactor** cycle.
Each kata is self-contained — no project references needed.

## How to Practice

1. Read the kata requirements below
2. Create a test class in this project
3. Write ONE failing test (RED)
4. Write minimal code to pass (GREEN) — implementation goes in the same file or a nested class
5. Refactor
6. Repeat until the kata is complete

## Kata 1: String Calculator ⭐

Create a `StringCalculator` with a method `int Add(string numbers)`:

1. Empty string returns 0
2. Single number returns its value: `"1"` → 1
3. Two numbers, comma-separated: `"1,2"` → 3
4. Handle any amount of numbers
5. Handle newlines as delimiters: `"1\n2,3"` → 6
6. Support custom delimiters: `"//;\n1;2"` → 3
7. Negative numbers throw an exception with the negative number in the message

**TDD sequence**: Write one test per step above. Don't read ahead.

## Kata 2: FizzBuzz ⭐

Create a `FizzBuzz` class with `string Generate(int number)`:

1. Returns the number as a string: 1 → "1"
2. Divisible by 3 → "Fizz"
3. Divisible by 5 → "Buzz"
4. Divisible by 3 and 5 → "FizzBuzz"

**Then extend**: `IEnumerable<string> GenerateRange(int start, int end)`

## Kata 3: Roman Numerals ⭐⭐

Create a `RomanNumeralConverter`:

`string ToRoman(int number)`:
1. Start with 1 → "I"
2. Then 2 → "II", 3 → "III"
3. Then 4 → "IV" (subtractive notation)
4. Then 5 → "V"
5. Build up incrementally through 1000

**TDD lesson**: Watch how the algorithm *emerges* from the tests. Don't plan ahead.

## Kata 4: Bowling Game ⭐⭐⭐

Create a `BowlingGame`:

`void Roll(int pins)` — record a roll
`int Score()` — calculate total score

1. Gutter game (all zeros) → 0
2. All ones → 20
3. Spare (10 pins in 2 rolls) → next roll bonus
4. Strike (10 pins in 1 roll) → next 2 rolls bonus
5. Perfect game → 300

**TDD lesson**: Complex state management. Tests guide you through the scoring rules.

## Kata 5: Bank Account (Outside-In) ⭐⭐⭐

Create a `BankAccount` that formats a statement:

```
Date       || Amount || Balance
14/01/2012 || -500   || 2500
13/01/2012 || 2000   || 3000
10/01/2012 || 1000   || 1000
```

- `Deposit(int amount)`, `Withdraw(int amount)`, `PrintStatement()` → string
- Use **London-school TDD**: mock a `IDateProvider` and `IStatementPrinter`

**TDD lesson**: Outside-in design. Start from `PrintStatement` and let the design emerge.
