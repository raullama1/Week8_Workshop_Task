using Microsoft.AspNetCore.Components;

namespace Week8.Pages
{
    public partial class Calculator
    {
        // Two-way bound input numbers
        private double Number1 { get; set; }
        private double Number2 { get; set; }

        // Result of calculation
        private double Result { get; set; }

        // Event handlers
        private void Add() => Result = Number1 + Number2;

        private void Subtract() => Result = Number1 - Number2;

        private void Multiply() => Result = Number1 * Number2;

        private void Divide() => Result = Number2 != 0 ? Number1 / Number2 : 0;
    }
}