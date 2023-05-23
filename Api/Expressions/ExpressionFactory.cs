using Api.Data.Entities;
using System.Linq.Expressions;

namespace Api.Expressions
{
    public class ExpressionFactory
    {
        public Expression<Func<User, User>> BuildExpFromStaticTypeToStaticType()
        {
            // 목표람다식: user => new User(){ Id = user.Id + 10, Name = user.Name + " changed!"

            // user
            ParameterExpression userParameter = Expression.Parameter(typeof(User), "user");
            // user.Id 
            MemberExpression idProperty = Expression.Property(userParameter, "Id");
            // + 10
            BinaryExpression addTenToId = Expression.Add(idProperty, Expression.Constant(10));
            
            // Id = user.Id + 10
            MemberBinding idBinding = Expression.Bind(typeof(User).GetProperty("Id")!, addTenToId);

            // user.Name
            MemberExpression nameProperty = Expression.Property(userParameter, "Name");
            // + "Changed!"
            BinaryExpression addChangedStr = Expression.Add(nameProperty, Expression.Constant("Changed!"),
                typeof(string).GetMethod("Concat", new[] { typeof(string), typeof(string) }));

            // Name = user.Name + "Changed!"
            MemberBinding nameBinding = Expression.Bind(typeof(User).GetProperty("Name")!, addChangedStr);


            // new User()
            NewExpression newUser = Expression.New(typeof(User));

            // new User(){ Id = user.Id + 10 , Name = user.Name + "Changed!" }
            MemberInitExpression memberInit = Expression.MemberInit(newUser, idBinding, nameBinding);

            // user => new User(){ Id = user.Id + 10 }
            Expression<Func<User, User>> lambdaExpression = Expression.Lambda<Func<User, User>>(memberInit, userParameter);

            return lambdaExpression;

        }

        public Expression<Func<User, dynamic>> BuildExpFromStaticTypeToDynamicType()
        {
            // dynamic 타입 생성시 Property가 아닌 Field를 이용할 것
            // 목표람다식: user => new { Id = user.Id, Name = user.Name + "***", More = user.Name + " more!" }

            TypeFactory typeFactory = new TypeFactory();
            List<TypeFactory.FieldInfo> fieldInfos = new List<TypeFactory.FieldInfo>()
            {
                new TypeFactory.FieldInfo("Id", typeof(int)),
                new TypeFactory.FieldInfo("Name", typeof(string)),
                new TypeFactory.FieldInfo("More", typeof(string))
            };
            Type dynamicType = typeFactory.CreateType(fieldInfos);

            // user
            ParameterExpression userParameter = Expression.Parameter(typeof(User), "user");
            // user.Id 
            MemberExpression userIdProperty = Expression.Property(userParameter, "Id");
            // Id = user.Id
            MemberBinding idBinding = Expression.Bind(dynamicType.GetField("Id")!, userIdProperty);

            // user.Name
            MemberExpression nameProperty = Expression.Property(userParameter, "Name");
            // + "***"
            BinaryExpression addStars = Expression.Add(nameProperty, Expression.Constant("***"),
                typeof(string).GetMethod("Concat", new[] { typeof(string), typeof(string) }));
            // Name = user.Name + "***!"
            MemberBinding nameBinding = Expression.Bind(dynamicType.GetField("Name")!, addStars);

            // + "***"
            BinaryExpression addMore = Expression.Add(nameProperty, Expression.Constant(" more!"),
                typeof(string).GetMethod("Concat", new[] { typeof(string), typeof(string) }));
            // Name = user.Name + "***!"
            MemberBinding moreBinding = Expression.Bind(dynamicType.GetField("More")!, addMore);


            // new ()
            NewExpression newDynamic = Expression.New(dynamicType);
            // new { Id = user.Id, Name = user.Name + "***", More = user.Name + " more!" }
            var initialization = Expression.MemberInit(newDynamic, idBinding, nameBinding, moreBinding);

            // user => new { Id = user.Id, Name = user.Name + "***", More = user.Name + " more!" }
            Expression<Func<User, object>> expression = Expression.Lambda<Func<User, object>>(initialization, userParameter);

            return expression;
        }
    }
}
