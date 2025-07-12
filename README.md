# Numberle – Console Mastermind Game in C#

**Numberle** is a console-based version of the classic game *Mastermind*, developed in C# for a programming assignment. The game challenges you to crack a 4-digit code using logical deduction within a limited number of attempts.

---

## 🧩 Game Rules

- The secret code consists of **4 distinct digits** from **0 to 8**.
- You have **10 attempts** (or a custom number) to guess the correct code.
- After each guess, the game tells you:
  - 🟩 **Well-placed pieces** – correct digit in the correct position.
  - 🟨 **Misplaced pieces** – correct digit in the wrong position.
- If you guess the code exactly, you win.
- If you use all attempts or press **Ctrl+D**, the game ends.

---

### Optional Command-Line Parameters

dotnet run -- -c 1234 -t 8
-c [CODE] → Use a custom secret code (must be 4 unique digits from 0 to 8)
-t [ATTEMPTS] → Set custom number of attempts (default: 10)



## How to Run

### Requirements
- .NET SDK 6.0 or later  
  Download: https://dotnet.microsoft.com/download

### ▶ Run from terminal

```bash
# Step into the project folder
cd your-folder-name

# Compile and run
dotnet run

```
https://github.com/Hvlv/Numberdle
© 2025 – Made with C#

