using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Primitives
{
    public static class ValidationMessage
    {
        public  static string NotNull { get; set; } = "Сущность не может быть NULL";
        public static string NotEmpty { get; set; } = "Сущность не может быть Empty";
        public static string LettersOnly { get; set; } = "Поле может содержать только буквы латинского или кириллического алфавита.";
        public static string CorrectDate { get; set; } = "Введена некоректная дата/возраст. Пользователю не может быть больше 120 лет";
    }
}
