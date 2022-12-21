namespace CopyBinaryFile
{
    using System;
    using System.IO;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using (FileStream reader = new FileStream(outputFilePath, FileMode.Open))
            {
                using (FileStream writer = new FileStream(inputFilePath, FileMode.Create))
                {
                    while (true)
                    {
                        byte[] bytes = new byte[512];
                        int size = reader.Read(bytes, 0, bytes.Length);
                        if (size == 0) break;
                        writer.Write(bytes, 0, size);
                    }
                }
            }
        }
    }
}
