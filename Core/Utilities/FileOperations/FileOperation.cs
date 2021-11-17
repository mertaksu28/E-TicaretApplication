using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.FileOperations
{
    public static class FileOperation
    {

        public static string FilePath = @"wwwroot\images";

        public static string FileAdd(IFormFile file)
        {

            var newFileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
            var saveToPlace = Path.Combine(Directory.GetCurrentDirectory(), FilePath, newFileName);
            using (var stream = new FileStream(saveToPlace, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            return newFileName;
        }

        public static bool DeleteFile(string fileName)
        {
            var fullPath = Path.Combine(Directory.GetCurrentDirectory(),FilePath,fileName);
            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
                return true;
            }
            return false;
        }

    }
}

            //Array.ForEach(Directory.GetFiles(FilePath), File.Delete);
            //return true;