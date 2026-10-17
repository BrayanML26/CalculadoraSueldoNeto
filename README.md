# CalculadoraSueldoNeto

A Windows Forms application that estimates the **net biweekly salary** in the Dominican Republic from a gross monthly salary. It subtracts the social security contributions (SFS and AFP) and the income tax (ISR).

> Small utility project. The tax brackets are constants in the code and need to be kept up to date by hand (see below).

## What it calculates

Enter the **gross monthly salary** and press the calculate button. The app shows:

| Result | How it is calculated |
|---|---|
| Gross biweekly salary | Monthly salary divided by 2 |
| SFS (health insurance) | 3.04% of the monthly salary, divided by 2 |
| AFP (pension) | 2.87% of the monthly salary, divided by 2 |
| ISR (income tax) | Annual taxable income (salary minus SFS and AFP, times 12) applied to the ISR brackets, divided by 24 |
| Net biweekly salary | Gross biweekly minus SFS, AFP and ISR |

ISR brackets used in the code:

| Annual taxable income | Rule |
|---|---|
| Up to 416,220.00 | Exempt |
| 416,220.01 to 624,329.00 | 15% of the excess over 416,220.00 |
| 624,329.01 to 867,123.00 | 31,216.00 plus 20% of the excess over 624,329.00 |
| Over 867,123.00 | 79,776.00 plus 25% of the excess over 867,123.00 |

Input validation only accepts digits and a single decimal point.

## Stack

- C#
- Windows Forms on .NET Framework 4.8

## Run it

Windows only. Open `CalculadoraSueldoNeto.sln` in Visual Studio, build the solution and run it.

## Keeping the brackets current

The brackets in `Form1.cs` are the ones from a previous tax year. The file keeps the updated values as comments (`ISR_BRACKET_1`, `ISR_BRACKET_2`, `ISR_BRACKET_3`, `ISR_FIXED_AMOUNT_1` and `ISR_FIXED_AMOUNT_2`). Replace the active constants with the current official values before relying on the result.

## Known limitations

- The result is an estimate. It does not apply the salary caps that the social security system uses for SFS and AFP, and it does not include other deductions or income.
- The rates and brackets are hardcoded instead of being configurable.
- There are no automated tests. Moving the calculation out of the form into its own class would make it testable.
