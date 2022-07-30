
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("2.1 Viết hàm đảo ngược 2 phần tử trong mảng theo vị trí.");
Console.WriteLine("2.1 Viết hàm đảo ngược 2 phần tử trong mảng theo vị trí.");
Console.WriteLine("2.3 Đếm số lượng giá trị lớn nhất có trong mảng");

Console.OutputEncoding = System.Text.Encoding.UTF8;
int temp;
Console.Write("\n Nhap vao so phan tu cua mang: ");
int n = Convert.ToInt32(Console.ReadLine());
//khai báo một mảng arr kiểu double với số phần tử là n được nhập ở trên
int[] arr = new int[n];
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(" Nhap vao gia tri cho phan tu thu {0}: ", i + 1);
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
foreach (var item in arr)
{
    Console.Write(item + " ");
}
Console.Write("\n Nhập vào phần tử đầu tiên bạn muốn đổi chỗ: ");
int soThuNhat = Convert.ToInt32(Console.ReadLine());
Console.Write("\n Nhập vào phần tử thứ hai bạn muốn đổi chỗ: ");
int soThuHai = Convert.ToInt32(Console.ReadLine());
if (soThuNhat < arr.Length && soThuHai < arr.Length)
{

    temp = arr[soThuNhat]; 
    arr[soThuNhat] = arr[soThuHai];
    arr[soThuHai] = temp;
    Console.Write("Cac phan tu sau khi sap xep:");
    foreach (var item in arr)
    {
        Console.Write(item + " ");
    }
}
else
{
    Console.WriteLine("Vượt qua số lượng mảng");
}
Console.WriteLine();
Console.WriteLine("------------------------------------------ - ");



//2.2.1 Code thuật toán bubble sort
for (int j = 0; j <= arr.Length - 2; j++)
{
    //sử dụng vòng for thứ hai để lặp qua từng cặp phần tử
    //thực hiện so sánh và đổi vị trí cho đúng thứ tự
    for (int i = 0; i <= arr.Length - 2; i++)
    {

        if (arr[i] > arr[i + 1])
        {
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[i];
            arr[i] = temp1;
        }
    }
}
Console.Write("Cac phan tu sau khi sap xep:");
//in các phần tử
foreach (int item in arr)
{
    Console.Write(item + " ");
}
Console.WriteLine();


//2.2.2 Code thuật toán Selection Sort
Console.WriteLine();
Console.WriteLine("---------------------------------------");
int nho_nhat;
for (int i = 0; i <= arr.Length - 2; i++)
{
    nho_nhat = i;

    for (int index = i + 1; index < arr.Length; index++)
    {
        if (arr[index] < arr[nho_nhat])
        {
            nho_nhat = index;
        }
    }
    int bien_tam = arr[i];
    arr[i] = arr[nho_nhat];
    arr[nho_nhat] = bien_tam;
}
Console.Write("Cac phan tu sau khi sap xep:");
foreach (var element in arr)
{
    Console.Write(element + " ");
}


//2.3 Đếm số lượng giá trị lớn nhất có trong mảng

Console.WriteLine();
Console.WriteLine("---------------------------------------");
int max = 0;
int bien_dem = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (max < arr[i])
        max = arr[i];
}
for (int i = 0; i < arr.Length; i++)
{

    if (arr[i] == max)
    {
        bien_dem += 1;
    }
}
Console.WriteLine("Phần tử lớn nhất trong mảng là:" + max);
Console.WriteLine("Số lần xuất hiện của phần tử lớn nhất là:" + bien_dem);


//2.4 Thêm 1 phần tử x vào mảng tại vị trí k


int[] arr1 = new int[10];
int phanTu, k, x;
Console.Write("\nChen phan tu vao mang trong C#: \n");
Console.Write("--------------------------------\n");
Console.Write("Nhap kich co mang: ");
phanTu = Convert.ToInt32(Console.ReadLine());
/* nhap cac phan tu vao trong mang*/
Console.Write("Nhap {0} phan tu vao trong mang:\n", phanTu);
for (int i = 0; i < phanTu; i++)
{
    Console.Write("Phan tu - {0}: ", i);
    arr1[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Nhap gia tri phan tu moi can chen: ");
x = Convert.ToInt32(Console.ReadLine());
Console.Write("Nhap vi tri can chen phan tu moi nay: ");
k = Convert.ToInt32(Console.ReadLine());
Console.Write("In mang ban dau:\n");
for (int i = 0; i < phanTu; i++)
    Console.Write("{0} ", arr1[i]);
/* di chuyen vi tri cac phan tu ben phai cua mang */
for (int i = phanTu; i >= k; i--)
    arr1[i] = arr1[i - 1];

arr1[k] = x;
Console.Write("\n\nSau khi chen phan tu, mang co dang:\n");
for (int i = 0; i <= phanTu; i++)
    Console.Write("{0} ", arr1[i]);
Console.Write("\n\n");
Console.ReadLine();


