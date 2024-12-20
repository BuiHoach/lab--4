using System.Text;

namespace lab_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            // Tạo đối tượng Document
            Document doc = new Document
            {
                Content = "Đây là nội dung của tài liệu."
            };

            string filename = "document.txt";
            Console.OutputEncoding = Encoding.Unicode;
            // Kiểm tra các chức năng
            doc.Write(filename); // Ghi nội dung vào file
            doc.Read(filename);  // Đọc nội dung từ file

            Console.WriteLine($"Nội dung hiện tại: {doc.Content}");

            doc.Encrypt(); // Mã hóa
            doc.Decrypt(); // Giải mã
        }
    }
}
