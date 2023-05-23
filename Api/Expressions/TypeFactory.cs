using System.Reflection;
using System.Reflection.Emit;

namespace Api.Expressions
{
    public class TypeFactory
    {
        public record FieldInfo(string Name, Type Type);

        public Type CreateType(IEnumerable<FieldInfo> fieldInfos)
        {
            AssemblyName dynamicAssemblyName = new AssemblyName("TempAssembly");
            AssemblyBuilder dynamicAssembly = AssemblyBuilder.DefineDynamicAssembly(dynamicAssemblyName, AssemblyBuilderAccess.Run);
            ModuleBuilder dynamicModule = dynamicAssembly.DefineDynamicModule("TempAssembly");
            TypeBuilder typeBuilder = dynamicModule.DefineType("AnonymousType", TypeAttributes.Public);

            /*
             * 속성을 정의하기 위해선 getter, setter를 따로 정의해야 한다.
             * 데이터 전달이 목적이므로 단순히 public field를 정의한다.
             */
            foreach (var fieldInfo in fieldInfos)
            {
                typeBuilder.DefineField(fieldInfo.Name, fieldInfo.Type, FieldAttributes.Public);
            }

            return typeBuilder.CreateType()!;
            
        }
    }
}
