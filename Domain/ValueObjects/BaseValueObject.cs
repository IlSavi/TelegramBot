using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public abstract class BaseValueObject
    {
        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj is null)
                return false;

            if (this.GetType() != obj.GetType())
            {
                return false;
            }

            string jsonThis = JsonSerializer.Serialize(this);
            string jsonOther = JsonSerializer.Serialize(obj);

            return jsonThis.Equals(jsonOther);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //// TODO: *Разобраться, как сравнить (DeepCompare => DeepClone)
        //public override bool Equals(object? obj)
        //{
        //    if (obj == null || GetType() != obj.GetType())
        //    {
        //        return false;
        //    }

        //    // Получаем список всех свойств и полей текущего объекта
        //    var fields = GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        //    //var properties = GetType().GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

        //    // Проверяем каждое свойство и поле на равенство
        //    foreach (var field in fields)
        //    {
        //        var thisValue = field.GetValue(this);
        //        var otherValue = field.GetValue(obj);
        //        if (!thisValue.Equals(otherValue))
        //        {
        //            return false;
        //        }
        //    }

        //    //foreach (var property in properties)
        //    //{
        //    //    var thisValue = property.GetValue(this);
        //    //    var otherValue = property.GetValue(obj);
        //    //    if (!thisValue.Equals(otherValue))
        //    //    {
        //    //        return false;
        //    //    }
        //    //}

        //    return true;
        //}
        //public override int GetHashCode()
        //{
        //    unchecked
        //    {
        //        int hash = 17;

        //        var fields = GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        //        //var properties = GetType().GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

        //        foreach (var field in fields)
        //        {
        //            var fieldValue = field.GetValue(this);
        //            hash = hash * 23 + (fieldValue?.GetHashCode() ?? 0);
        //        }

        //        //foreach (var property in properties)
        //        //{
        //        //    var propertyValue = property.GetValue(this);
        //        //    hash = hash * 23 + (propertyValue?.GetHashCode() ?? 0);
        //        //}

        //        return hash;
        //    }
        //}
    }
}
