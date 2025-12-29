# Pansiyon Yönetim Sistemi

Bu proje, bir pansiyonun günlük yönetim süreçlerini dijital ortamda takip edebilmek amacıyla geliştirilmiş bir Windows Forms uygulamasıdır.

Uygulama; oda durumlarının takibi, müşteri kayıt işlemleri, gelir–gider hesaplamaları ve kullanıcı yetkilendirme gibi temel işlevleri tek bir sistem altında toplamayı hedeflemektedir.

---

## Projenin Amacı

Bu projenin amacı, pansiyon işletmelerinde manuel olarak yapılan işlemleri azaltmak, verilerin daha düzenli ve güvenli şekilde tutulmasını sağlamak ve işletme süreçlerini kolaylaştırmaktır.

---

## Kullanılan Teknolojiler

- C# (Windows Forms)
- MSSQL Server
- ADO.NET
- Visual Studio

---

## Kullanıcı Rolleri

Uygulama rol tabanlı bir yapıya sahiptir:

- **Admin**  
  Tüm modüllere ve yönetimsel işlemlere erişim yetkisine sahiptir.

- **Personel**  
  Gelir–Gider modülü dışında tüm işlemleri gerçekleştirebilir.

- **Müşteri**  
  Sadece bilgilendirme amaçlı modüllere erişebilir.

---

## Modüller

- Giriş ve Yetkilendirme
- Ana Sayfa
- Odalar
- Yeni Müşteri Kayıt
- Müşteri Listeleme
- Gelir–Gider
- Stoklar
- Mesajlar
- Radyo
- Gazete
- Hakkımızda
- Şifre İşlemleri

---

## Veri Tabanı

Uygulama, MSSQL Server üzerinde oluşturulmuş bir veritabanı kullanmaktadır.  
Kullanıcı bilgileri, müşteri kayıtları, oda durumları ve finansal veriler ayrı tablolar halinde saklanmaktadır.

---

## Kurulum

1. Proje klasörünü bilgisayarınıza indirin.
2. Visual Studio ile `.sln` dosyasını açın.
3. MSSQL Server üzerinde gerekli veritabanını oluşturun.
4. Veritabanı bağlantı cümlesini kendi sisteminize göre düzenleyin.
5. Uygulamayı çalıştırın.

---

## Geliştirici Notu

Bu proje eğitim amaçlı geliştirilmiştir.

---

# Pension Management System

This project is a Windows Forms application developed to digitally manage the daily operations of a pension business.

The application aims to bring together essential functions such as room status tracking, customer registration, income–expense management, and user authorization within a single system.

---

## Project Purpose

The purpose of this project is to reduce manual operations in pension management, ensure that data is stored in a more organized and secure manner, and simplify business processes.

---

## Technologies Used

- C# (Windows Forms)
- MSSQL Server
- ADO.NET
- Visual Studio

---

## User Roles

The application is based on a role-based access control system:

- **Admin**  
  Has full access to all modules and administrative operations.

- **Staff**  
  Can perform all operations except the Income–Expense module.

- **Customer**  
  Has access only to informational modules.

---

## Modules

- Login and Authorization
- Main Page
- Rooms
- New Customer Registration
- Customer Listing
- Income–Expense
- Stocks
- Messages
- Radio
- Newspaper
- About Us
- Password Management

---

## Database

The application uses a database created on MSSQL Server.  
User information, customer records, room statuses, and financial data are stored in separate tables.

---

## Installation

1. Download the project folder to your computer.
2. Open the `.sln` file using Visual Studio.
3. Create the required database on MSSQL Server.
4. Update the database connection string according to your system.
5. Run the application.

---

## Developer Note

This project was developed for educational purposes.
