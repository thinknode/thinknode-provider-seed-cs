using System;
using MsgPack;
using MsgPack.Serialization;

namespace App
{
    public class Person
    {
        public String name;
        public int age;

        public Person(String n, int a)
        {
            name = n;
            age = a;
        }

        public override string ToString()
        {
            return string.Format("name: {0}; age: {1}", name, age);
        }
    }

    public class PersonSerializer : MessagePackSerializer<Person>
    {
        public PersonSerializer(SerializationContext ownerContext) : base(ownerContext) {}

        protected override void PackToCore(Packer packer, Person objectTree)
        {
            packer.PackMapHeader(2);
            packer.Pack("name");
            packer.Pack(objectTree.name);
            packer.Pack("age");
            packer.Pack(objectTree.age);
        }

        protected override Person UnpackFromCore(Unpacker unpacker)
        {
            MessagePackObject obj = unpacker.UnpackSubtreeData();
            MessagePackObjectDictionary dict = obj.AsDictionary();
            MessagePackObject objName = new MessagePackObject();
            MessagePackObject objAge = new MessagePackObject();
            dict.TryGetValue("name", out objName);
            dict.TryGetValue("age", out objAge);
            String name = objName.AsStringUtf8();
            int age = objAge.AsInt32();
            return new Person(name, age);
        }
    }
}

