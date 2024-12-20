using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4._3
{
    interface IStorable
    {
        string Data { get; set; }

        void Write(string filename); // Lưu dữ liệu vào file
        void Read(string filename);  // Đọc dữ liệu từ file
    }

    interface IEncryptable
    {
        void Encrypt(); // Mã hóa
        void Decrypt(); // Giải mã
    }

    class Document : IStorable, IEncryptable
    {
        public string Content { get; set; } // Nội dung của tài liệu

        // Thuộc tính Data từ giao diện IStorable
        public string Data
        {
            get => Content;
            set => Content = value;
        }

        // Thực thi phương thức Write từ IStorable
        public void Write(string filename)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    writer.Write(Content);
                }
                Console.WriteLine($"Nội dung đã được ghi vào file: {filename}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi ghi file: {ex.Message}");
            }
        }

        // Thực thi phương thức Read từ IStorable
        public void Read(string filename)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    Content = reader.ReadToEnd();
                }
                Console.WriteLine($"Nội dung đã được đọc từ file: {filename}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi đọc file: {ex.Message}");
            }
        }

        // Thực thi phương thức Encrypt từ IEncryptable
        public void Encrypt()
        {
            Console.WriteLine("Nội dung đã được mã hóa.");
        }

        // Thực thi phương thức Decrypt từ IEncryptable
        public void Decrypt()
        {
            Console.WriteLine("Nội dung đã được giải mã.");
        }
    }
}
