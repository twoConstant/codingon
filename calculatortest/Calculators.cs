using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatortest
{
    public class Calculators
    {

        private readonly StringBuilder sbForCase = new StringBuilder();
        private readonly StringBuilder sbForHistory = new StringBuilder();
        private double currentDouble = 0;
        private string latestInputOperation = "";


        // 수랑 operatior를 같이 받아서 현재 수식을 반환
        public string GetLatestFormula(string inputNumStr, string operators)
        {
            sbForCase.Append(inputNumStr).Append(operators);
            // currentDouble 최신화
            UpdateCurrentDouble(inputNumStr);
            // 기존의 lastInputOperation 기반으로 최신화
            latestInputOperation = operators;

            return sbForCase.ToString();
        }

        // 등호 눌렀을때 저장하기
        public string SubmitAndGetResult(string inputNumStr)
        {
            string latestFomula = sbForCase.ToString();
            UpdateCurrentDouble(inputNumStr);
            string result = GetCurrentDouble();
            sbForHistory.Append($"{latestFomula} = {result}\r\n");
            InitCase();
            return $"{latestFomula} = {result}\r\n";
        }

        // C를 눌렀을때
        public void InitCase()
        {
            sbForCase.Clear();
            currentDouble = 0;
            latestInputOperation = "";
        }


        private void UpdateCurrentDouble(string inputNumStr)
        {
            double inputNum = double.Parse(inputNumStr);

            switch (latestInputOperation)
            {
                case "+":
                    currentDouble += inputNum;
                    return;
                case "-":
                    currentDouble -= inputNum;
                    return;
                case "÷":
                    currentDouble /= inputNum;
                    return;
                case "×":
                    currentDouble *= inputNum;
                    return;
                default:    // 공백일 경우 즉 첫 숫자인경우
                    currentDouble = inputNum;
                    return;
            }
        }

        public string GetCurrentDouble()
        {
            return currentDouble.ToString();
        }

    }
}
