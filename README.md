Bu dersde mssql de  daha önce oluşturduğumuz veritabanındaki
Guide ve Location tablolarından ef core ile veri çekerek istatistik
işlemlerinin sonuçlarını form ekranımıza yazdırdık.Lokasyon sayısını
Count metodunu kullanarak,lokasyonların toplam kapasite sayısını Sum fonksiyonu
içerisine lampda ifadeler yazarak,Toplam rehber sayısını Count metodunu 
kullanarak,Lokasyonların ortalama kapasitesini Average metodu içerisine lampda ifadeler
yazarak,En son eklenen ülkeyi önce Max metodu içerisine yazdığımız lampda ifadeler
ile id sini aldıktan sonra Where metodu içerisinde lampda ifadeler ile şartımızı 
yazarak ve Select metodu ile şarta uyan ifadelerin County değerlerini getirip 
FirstOrDefault metodu ile ilk değeri alarak (Burada zaten şartımızdan tek veri 
dönüyor bizde FirstOrDefault ile onu alıyoruz).Ortalama tur fiyatını gene Avg 
metodumuz sayesinde alıyoruz ve burda hocamız virgülden sonra son iki rakamı
istediği için ve çalıştığım .net sürümünde decimal türü için ToString metodu overload edilemdiği için double ile parse işlemi uygulayıp ToString metodunu
öyle overload ettim.Kapodakya tur kapasitesini gene where ve Average metodları
ile bulduk.Türkiye turlarının kapasitesini de gene where ve Average metodları 
ile hesapladık.Roma gezi rehberini de önce bir var değere rehber id yi atayıp
sonra sonra where ile gelen id ile aynı değere sahip rehberi bulduk.En
yüksek kapasiteli tur'u da var tipinde değişkene Max metodundan gelen değeri 
atayıp daha sonra bu değeri where ile Location tablodunda kontrol ediğ atadık ve
aynı mantığı En pahalı tur u bulurken de kullandık.En sonda Ayşegül çınarın 
tur sayısını bulurken where ile ad soyad şartı sağladık ve select ile id leri alıp 
FirstOrDefault ile ilk id yi aldık daha sonra alt satırda Location tablosunda
where ile aynı id ye sahip değerleri aldık ve  Count metodu ile sayılarını 
hesapladık.




![mrtKampCase3](https://github.com/user-attachments/assets/493b94c5-d94d-4311-a328-fd20156b1311)
