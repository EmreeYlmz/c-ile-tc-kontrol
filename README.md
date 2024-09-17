T.C. Kimlik Numarası Doğrulama Uygulaması
 * Bu uygulama, kullanıcıdan alınan T.C. kimlik numarasını gerçek zamanlı olarak doğrulayan bir Windows Forms uygulamasıdır. Kullanıcının girdiği her bir hane üzerinde kontroller yapılır ve hata olduğunda kullanıcı bilgilendirilir. Doğru T.C. kimlik numarası girildiğinde, butona tıklandığında doğrulama başarılı mesajı gösterilir.

Özellikler:
* T.C. kimlik numarasının ilk hanesinin '0' olmasını engeller.
  ve 11. hanede yapılan matematiksel kontroller ile geçerlilik kontrolü sağlar.
 *Hatalı girişlerde kullanıcıyı ErrorProvider ile bilgilendirir.
* Başarılı doğrulamada mesaj kutusu ile kullanıcıya bilgi verir.
Teknolojiler:
* C#
* Windows Forms
* .NET Framework
Nasıl Çalışır:
* Kullanıcı, T.C. kimlik numarasını giriş alanına yazar.
* Klavyeden her bir tuşa basıldığında, ilgili hane için gerekli kontroller yapılır.
* Geçersiz bir giriş yapıldığında kullanıcıya uyarı verilir.
* Doğru girilmiş T.C. kimlik numarası ile butona tıklanıldığında doğrulama başarılı mesajı gösterilir.
