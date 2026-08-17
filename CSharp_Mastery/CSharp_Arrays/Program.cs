//Single Dimension Array

int[] ages = new int[20];
ages = new int[30];

ages[0] = 23;
ages[1] = 24;
ages[2] = 25;
ages[3] = 26;
ages[4] = 27;

Console.WriteLine(ages[4]);

//2 dimensional Array

int[,] board = new int[10, 10];
board[0, 0] = 1;
board[0, 1] = 2;
board[2, 3] = 30;
board[4, 9] = 11;
board[7, 8] = 111;

int temp = board[2, 3];

Console.WriteLine(temp);

//3 dimensional array

int[,,] cube = new int[10, 10, 10];
cube[3, 3, 7] = 111;
cube[2, 3, 6] = 222;

Console.WriteLine(cube[2, 3, 6]);

//2D Jagged array

int[][] jagged2d = new int[20][];
jagged2d[1] = new int[5];
jagged2d[4] = new int[8];

jagged2d[1][2] = 15;

Console.WriteLine(jagged2d[1][2]);

//3D Jagged Array

int[][][] jagged3d = new int[20][][];
jagged3d[0] = new int[20][];
jagged3d[1] = new int[10][];

jagged3d[1][1] = new int[5];

Console.WriteLine(jagged2d[1][1]);

int[] setvalue1 = new int[] { 10, 20, 30 };
int aa = setvalue1[0];//value is 10
int aa2 = setvalue1[2];//value is 20

//Deferent inseret convention

int[,] setvalue2 = new int[,]
{
    {10, 20},
    {30, 40}
};

int bb = setvalue2[0,0];
int bb2 = setvalue2[1,0];

Console.WriteLine(bb);
Console.WriteLine(bb2);

