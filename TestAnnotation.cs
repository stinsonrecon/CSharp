using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

public class TestAnnotation{
public static void checkValidationContext()
    {
        Employee user    = new Employee();
        user.Name        = "AF";
        user.Age         = 6;
        user.PhoneNum = "1234as";
        user.Email       = "test@re";


        ValidationContext context       = new ValidationContext(user, null, null);
        // results - lưu danh sách ValidationResult, kết quả kiểm tra
        List<ValidationResult> results  = new List<ValidationResult>();
        // thực hiện kiểm tra dữ liệu
        bool valid = Validator.TryValidateObject(user, context, results, true);

        if (!valid)
        {
            // Duyệt qua các lỗi và in ra
            foreach (ValidationResult vr in results)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{vr.MemberNames.First(), 13}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"    {vr.ErrorMessage}");
            }
        }
    }
}
