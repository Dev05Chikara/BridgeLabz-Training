using System;
class MatrixOperations{
	static Random R=new Random();
    static int[,] CreateMatrix(int Rows,int Cols){
        int[,] Matrix=new int[Rows,Cols];
        for(int i=0;i<Rows;i++) for(int j=0;j<Cols;j++) Matrix[i,j]=R.Next(1,10);
        return Matrix;
    }
    static void DisplayMatrix(int[,] M){
        for(int i=0;i<M.GetLength(0);i++){
            for(int j=0;j<M.GetLength(1);j++) Console.Write(M[i,j]+"\t");
            Console.WriteLine();
        }
    }
    static int[,] AddMatrix(int[,] A,int[,] B){
        int[,] C=new int[A.GetLength(0),A.GetLength(1)];
        for(int i=0;i<A.GetLength(0);i++) for(int j=0;j<A.GetLength(1);j++) C[i,j]=A[i,j]+B[i,j];
        return C;
    }
    static int[,] SubtractMatrix(int[,] A,int[,] B){
        int[,] C=new int[A.GetLength(0),A.GetLength(1)];
        for(int i=0;i<A.GetLength(0);i++) for(int j=0;j<A.GetLength(1);j++) C[i,j]=A[i,j]-B[i,j];
        return C;
    }
    static int[,] MultiplyMatrix(int[,] A,int[,] B){
        int[,] C=new int[A.GetLength(0),B.GetLength(1)];
        for(int i=0;i<A.GetLength(0);i++) for(int j=0;j<B.GetLength(1);j++) for(int k=0;k<A.GetLength(1);k++) C[i,j]+=A[i,k]*B[k,j];
        return C;
    }
    static int[,] TransposeMatrix(int[,] A){
        int[,] T=new int[A.GetLength(1),A.GetLength(0)];
        for(int i=0;i<A.GetLength(0);i++) for(int j=0;j<A.GetLength(1);j++) T[j,i]=A[i,j];
        return T;
    }
    static int Determinant2x2(int[,] M){
        return (M[0,0]*M[1,1]-M[0,1]*M[1,0]);
    }
    static int Determinant3x3(int[,] M){
        return (M[0,0]*(M[1,1]*M[2,2]-M[1,2]*M[2,1]) - M[0,1]*(M[1,0]*M[2,2]-M[1,2]*M[2,0]) + M[0,2]*(M[1,0]*M[2,1]-M[1,1]*M[2,0]));
    }
    static double[,] Inverse2x2(int[,] M){
        double[,] Inv=new double[2,2];
        int Det=Determinant2x2(M);
        if(Det==0) return null;
        Inv[0,0]=M[1,1]/(double)Det;
        Inv[0,1]=-M[0,1]/(double)Det;
        Inv[1,0]=-M[1,0]/(double)Det;
        Inv[1,1]=M[0,0]/(double)Det;
        return Inv;
    }
    static void DisplayDoubleMatrix(double[,] M){
        for(int i=0;i<M.GetLength(0);i++){
            for(int j=0;j<M.GetLength(1);j++) Console.Write(Math.Round(M[i,j],2)+"\t");
            Console.WriteLine();
        }
    }
    static void Main(){
        int[,] A=CreateMatrix(3,3);
        int[,] B=CreateMatrix(3,3);
        Console.WriteLine("Matrix A:");
        DisplayMatrix(A);
        Console.WriteLine("Matrix B:");
        DisplayMatrix(B);
        Console.WriteLine("Addition:");
        DisplayMatrix(AddMatrix(A,B));
        Console.WriteLine("Subtraction:");
        DisplayMatrix(SubtractMatrix(A,B));
        Console.WriteLine("Multiplication:");
        DisplayMatrix(MultiplyMatrix(A,B));
        Console.WriteLine("Transpose of A:");
        DisplayMatrix(TransposeMatrix(A));
        Console.WriteLine("Determinant of A:");
        Console.WriteLine(Determinant3x3(A));
        int[,] M2=CreateMatrix(2,2);
        Console.WriteLine("2x2 Matrix:");
        DisplayMatrix(M2);
        Console.WriteLine("Determinant:");
        Console.WriteLine(Determinant2x2(M2));
        Console.WriteLine("Inverse:");
        double[,] Inv=Inverse2x2(M2);
        if(Inv!=null) DisplayDoubleMatrix(Inv);
        else Console.WriteLine("Inverse not possible");
    }
}
