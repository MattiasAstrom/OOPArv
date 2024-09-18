//Author: Mattias Åström NET24
namespace OOPArv
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new();
            Cat cat = new();
            Bird bird = new();
            Bulldog bulldog = new();
            Chihuahua chihuahua = new();

            dog.MakeSound("bark bark bark - Unknown Dog");
            cat.MakeSound("meow meow - Unknown Cat");
            bird.MakeSound("chirp chirp - Unknown bird");
            bulldog.MakeSound("bark bark - Bulldog");
            chihuahua.MakeSound("bark bark - Chihuahua");

            Console.WriteLine("\n");

            dog.DestroyTheLivingRoom();
            cat.LikesHuman();
            bird.CheckIfBathroomBreak();
            bulldog.SeesHuman();
            chihuahua.NoticeStranger();
        }
    }

    class Animal
    {
        protected bool _hungry;
        protected bool _sleepy;
        protected bool _hasAnOwner;
        protected string _name;
        protected int _age;

        public Animal(bool isHungry, bool isSleepy, string name, int age, bool hasAnOwner)
        {
            _hungry = isHungry;
            _sleepy = isSleepy;
            _name = name;
            _age = age;
            _hasAnOwner = hasAnOwner;
        }

        public Animal()
        {
            _hungry = false;
            _sleepy = false;
            _name = "animal name not set";
        }


        public bool IsHungry()
        {
            return _hungry;
        }
        public bool IsSleepy()
        {
            return _sleepy;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public void MakeSound(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    class Cat : Animal
    {
        bool likesHuman;

        public Cat(bool isHungry, bool isSleepy, string name, bool catLikesHuman, int age, bool hasAnOwner) : base(isHungry, isSleepy, name, age, hasAnOwner)
        {
            likesHuman = catLikesHuman;
        }
        public Cat() : base()
        {
            likesHuman = false;
        }

        public new void MakeSound(string msg) => base.MakeSound(msg);

        public void LikesHuman()
        {
            Console.WriteLine(likesHuman ? "Cat likes the human" : "Cat does not like the human");
        }

    }

    class Bird : Animal
    {
        bool willPoopOnCar;

        public Bird(bool isHungry, bool isSleepy, string name, bool poopOnCar, int age, bool hasAnOwner) : base(isHungry, isSleepy, name, age, hasAnOwner)
        {
            willPoopOnCar = poopOnCar;
        }

        public Bird() : base()
        {
            willPoopOnCar = false;
        }

        public new void MakeSound(string msg) => base.MakeSound(msg);

        public void CheckIfBathroomBreak()
        {
            Console.WriteLine(willPoopOnCar ? "Bird will find a nice clean car." : "Bird will not ruin someones day today.");
        }
    }

    class Dog : Animal
    {
        bool destroyLivingRoom;

        public Dog(bool isHungry, bool isSleepy, string name, bool shouldDestroyLivingRoom, int age, bool hasAnOwner) : base(isHungry, isSleepy, name, age, hasAnOwner)
        {
            destroyLivingRoom = shouldDestroyLivingRoom;
        }

        public Dog() : base()
        {
            destroyLivingRoom = false;
        }

        public new void MakeSound(string msg) => base.MakeSound(msg);

        public void DestroyTheLivingRoom()
        {
            Console.WriteLine(destroyLivingRoom ? "Dog will destroy the living room now." : "Dog will not destroy the living room.");
        }
    }

    class Bulldog : Dog
    {
        bool playWithHuman;

        public Bulldog(bool isHungry, bool isSleepy, string name, bool shouldDestroyLivingRoom, bool shouldPlayWithHuman, int age, bool hasAnOwner)
            : base(isHungry, isSleepy, name, shouldDestroyLivingRoom, age, hasAnOwner)
        {
            playWithHuman = shouldPlayWithHuman;
        }

        public Bulldog() : base()
        {
            playWithHuman = false;
        }

        public new void MakeSound(string msg) => base.MakeSound(msg);

        public void SeesHuman()
        {
            Console.WriteLine(playWithHuman ? "Bulldog plays with human." : "Bulldog ignores human.");
        }

    }

    class Chihuahua : Dog
    {
        bool beAggressive;

        public Chihuahua(bool isHungry, bool isSleepy, string name, bool shouldDestroyLivingRoom, bool shouldBeAggressive, int age, bool hasAnOwner)
            : base(isHungry, isSleepy, name, shouldDestroyLivingRoom, age, hasAnOwner)
        {
            beAggressive = shouldBeAggressive;
        }

        public Chihuahua() : base()
        {
            beAggressive = true;
        }

        public new void MakeSound(string msg) => base.MakeSound(msg);

        public void NoticeStranger()
        {
            Console.WriteLine(beAggressive ? "Chihuahua attacks stranger." : "Chihuahua growls at stranger.");
        }
    }
}