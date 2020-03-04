using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Facade
    {
        public void WorkProgramm()
        {
            int n = 0;
            int op = 9;
            int degree = 1;
            double[,] resultMass = new double[n, n];
            double[,] mas = new double[n, n];
            double[,] mas2 = new double[n, n];
            MatrixOperationLib.IMatrixOperation matOper = new MatrixOperationLib.MatrixOpeerations();
            IInputValues inpValues = new Values();
            IShowInformation showInf = new Information();
            showInf.ShowUI();
            op= inpValues.MatrixSizeOrChoseOperation();
            switch (op)
            {
                case 0:
        
                    break;
                case 1:
                    showInf.InputMatrixSize();
                    n=inpValues.MatrixSizeOrChoseOperation();
                    showInf.InputMatrix();
                    mas = inpValues.InputMas(n);
                    showInf.InputMatrix();
                    mas2 = inpValues.InputMas(n);
                    showInf.ShowMatrix(ref mas, ref mas2, ref n);
                    resultMass=matOper.SumMatrix(ref mas,ref mas2, ref n);
                    showInf.ShowResult(ref resultMass, ref n);
                    WorkProgramm();
                    break;
                case 2:
                    showInf.InputMatrixSize();
                    n = inpValues.MatrixSizeOrChoseOperation();
                    showInf.InputMatrix();
                    mas = inpValues.InputMas(n);
                    showInf.InputMatrix();
                    mas2 = inpValues.InputMas(n);
                    showInf.ShowMatrix(ref mas, ref mas2,ref n);
                    resultMass=matOper.SubtructionMatrix(ref mas,ref mas2,ref n);
                    showInf.ShowResult(ref resultMass, ref n);
                    WorkProgramm();
                    break;
                case 3:
                    showInf.InputMatrixSize();
                    n = inpValues.MatrixSizeOrChoseOperation();
                    showInf.InputMatrix();
                    mas = inpValues.InputMas(n);
                    showInf.InputMatrix();
                    mas2 = inpValues.InputMas(n);
                    showInf.ShowMatrix(ref mas, ref mas2, ref n);
                    resultMass = matOper.MultMatrix(mas, mas2, ref n);
                    showInf.ShowResult(ref resultMass, ref n);
                    WorkProgramm();
                    break;
                case 4:
                    showInf.InputMatrixSize();
                    n = inpValues.MatrixSizeOrChoseOperation();
                    showInf.InputDegre();
                    degree = inpValues.MatrixSizeOrChoseOperation();
                    showInf.InputMatrix();
                    mas = inpValues.InputMas(n);
                    resultMass = matOper.MultMatrix(mas, mas, ref n);
                    showInf.ShowResult(ref resultMass, ref n);
                    WorkProgramm();
                    break;
            }
            
        }
    }
}

