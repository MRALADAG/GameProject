using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class PlayerManager : IPlayerService
    {
        List<Player> _players;
        IPlayerValidationService _playerValidationService;

        //public PlayerManager()
        //{
        //    _player = new List<Player> {
        //        new Player {BirthDay = Convert.ToDateTime("30.01.1988"),
        //                    FirstName = "MELİH",
        //                    LastName = "AKIN",
        //                    Id = 1,
        //                    TcNo = 12345678911 },
        //        new Player {BirthDay = Convert.ToDateTime("30.01.1990"),
        //                    FirstName = "ÇINAR",
        //                    LastName = "YILMAZ",
        //                    Id = 2,
        //                    TcNo = 12345678912 }
        //        };
        //}

        // Operasyon içeren sınıfların öncelikle abstract sınıfları oluşturulur.
        // Daha sonra implemente ve inherit edilir.
        // Eğer bir sınıf dışarıdan başka bir servisi kullanıyorsa buna MicroService denir.

        // Bir operasayonel sınıf içerisinde başka bir operasyonel sınıfın metodunu kullanacaksa kural olarak 
        // kullanılmak istenilen servisin class'ını asla new'leme. Bunun yerine onu bir constructor içerisinde kullan.
        // Fakat constructor içerisinde kullanılan servis somut bir servis değildir, servisin abstract'ı dır.
        // PlayerManager içerisinde biz IPlayerValidationService'i kullanarak 
        // oyuncunun kimlik doğrulamasını yapmak istiyoruz.
        // Bunu yapmak için IPlayerValidationService sınıfının objesini öncelikle bu sınıfta oluşturmamız lazım.
        // Fakat bizim bunu bu sınıf içerinde new anahtar sözcüğü kullanmadan yapmamız lazım.
        // Bunun içinde IPlayerValidationService tipinde bir global değişken tanımlayıp bunu constructor içerisinde
        // injection yapmamız gerekir. (dependency injection)


        public PlayerManager(IPlayerValidationService playerValidationService)
        {
            _playerValidationService = playerValidationService;
            _players = new List<Player> { };
        }


        // Burada IPlayerValidationService MicroService'inden yararlanılmıştır.
        // Böylece ileride başka ValidationService MicroService'lerine geçilmek istenir ise diğer MicroService'lerde
        // IPlayerValidationService sınıfından inherit edilmek suretiyle burada switch edilebilir.

        public void Add(Player player)
        {
            if (_playerValidationService.Validate(player) == true)
            {
                Console.WriteLine("Kayıt oldu.");
                _players.Add(player);
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız oldu.");
            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Kayıt Silindi.");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }

        public List<Player> GetAllPlayers()
        {
            return _players;
        }
    }
}
