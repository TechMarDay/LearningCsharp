OOP



1. Định nghĩa:
OOP (object oriented programming) là một phương pháp lập trình sử dụng đối tượng để xây dựng ứng dụng phần mềm.
2. Class
Là đại diện cho đối tượng có chung các đặc điểm, hành vi, phương thức hoạt động.
3. Method (phương thức)
Là hành động của đối tượng thực hiện một tác vụ nào đó.
4. Field (trường)
Dùng để lưu trữ đặc điểm đối tượng và chỉ dùng riêng bên trong đối tượng (biến cục của class). Thường đi kèm private.
5. Property (thuộc tính)
Để truy cập field ở bên ngoài thì ta sẽ sử dụng thuộc tính (property). Đi kèm với hai từ khóa GET và SET (accessor)
6. Object(Đối tượng)
Đối tượng này là một thực thể trong thế giới thực, nó các đặc điểm và hành vi.
Object với Class.
Object là một thể hiện (instance) của class.
Class là khuôn mẫu thì object là đối tượng được tạo ra từ khuôn đó.


7.Tính chất hướng đối tượng

- Tính đóng gói (Encapsulation): Che giấu thông tin và đóng gói => giúp toàn vẹn và bảo mật dữ liệu của đối tượng.

C# những từ khóa: public, protected, privated, internal (access modifer)

Public: Cho phép đối tượng bên ngoài truy cập dữ liệu (thuộc tính, phương thức) của đối tượng.
privated: Chỉ cho phép đối tượng bên trong class sử dụng những thuộc tính, phương thức.
protected: Cho phép đối tượng con truy cập dữ liệu (thuộc tính, phương thức) của đối tượng cha.
internal: Cho phép đối tượng truy cập dữ liệu trong cùng assembly. (Hiểu trong 1 project)

//Ứng dụng: internal sử dụng để viết thư viện hạn chế dự án, thư viện bên ngoài truy cập class, method, properties.

- Tính kế thừa (Inheritance)
Cho phép tạo ra class con dựa trên class có sẵn (class cha). Class con sẽ sử dụng được những thuộc tính, phương thức của
class cha.

Class con có thể ghi đè những thuộc tính, phương thức của class cha.
Class có thể khai báo những thuộc tính và thuộc tính mới.

- Class con - class dẫn xuất - base class - derived class.

- Tính đa hình (Polymorphism)
Tính đa hình giúp một đối tượng có thể thực hiện một hành động theo nhiều cách khác nhau.
//Employee
//SayHello
//Developer: Hi everybody, I'm .net developer
//Tester: Hi everybody, I'm automation tester.

C# nó sử dụng 2 kỹ thuật:
- Overriding (ghi đè) (Runtime - chạy chương trình)
Cho phép các class con có các cách thể hiện các phương thức khác nhau so với phương thức của class cha.
- Overloading (nạp chồng) (Complite - biên dịch chương trình)
Được sử dụng trong cùng class. Nó cho phép khai báo các phương thức cùng tên, khác nhau về số lượng,
kiểu dữ liệu của tham số truyền vào.


- Tính trừu tượng, construct, destructor, solid



#Bài tập về nhà:
Phần mềm quản lý nhân viên gồm 3 loại nhân viên (Experience, Fresher, Intern)

Xây dựng lớp nhân viên gồm các thuộc tính: Mã nhân viên, họ, tên , tuổi, số điện thoại, email.
Xây dựng lớp nhân viên Experience gồm các thuộc tính kế thừa từ lớp nhân viên và bổ sung thêm thuộc tính: số năm kinh nghiệm, kỹ năng chuyên môn.
Xây dựng lớp nhân viên Fresher gồm các thuộc tính kế thừa từ lớp nhân viên và bổ sung thêm thuộc tính: thời gian tốt nghiệp, loại tốt nghiệp và trường tốt nghiệp.
Xây dựng lớp nhân viên Intern gồm các thuộc tính kế thừa từ lớp nhân viên và bổ sung thêm thuộc tính: chuyên nghành đang học, học kỳ, tên trường đang học.
Có các chức năng:

Lấy ra tên của nhân viên.
Lấy ra thông tin của nhân viên. Sẽ được bổ sung các thuộc tính tùy theo loại nhân viên.
Chức năng gửi mail cho nhân viên. (tương tự project mẫu)



