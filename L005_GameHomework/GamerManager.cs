using System;
using System.Collections.Generic;
using System.Text;

namespace L005_GameHomework
{
    // MicroServices
    // Manager Class Yapısı içinde farklı bir Manager Class kullanmak istendiğinde new keyword kullanılmaz. Constructor oluşturulur.
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if(_userValidationService.Validate(gamer) == true)
                Console.WriteLine("Yeni Oyuncu Eklendi.");
            else
                Console.WriteLine("Verilerinizi Lütfen Doğru Yazınız!");
        }

        public void Delete()
        {
            Console.WriteLine("Oyuncu Silindi.");
        }

        public void Update()
        {
            Console.WriteLine("Oyuncu Verileri Güncellendi.");
        }
    }
}
