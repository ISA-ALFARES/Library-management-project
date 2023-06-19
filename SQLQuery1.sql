
/*

**************************************************************************************************************************************
**************Tüm Katigori tablosu işlemlerinin başlangıcı***
************************************************************
************************görüntüleme işlemi******************

 CREATE PROCEDURE Pr_LOADCATSS

AS
	select * from  T_CAT

************************************************************
************************ekleme işlemi******************


	CREATE PROCEDURE CAT_ADDss
	@CAT_NAME varchar(100)
	AS
	insert into T_CAT values (@CAT_NAME)

************************************************************
silme işlemi
--TRUNCATE TABLE T_CAT

************************************************************
************************güncelleme işlemi ******************

ALTER PROCEDURE CAT_EDIT
@CAT_NAME varchar(100),
@ID int
AS
UPDATE T_CAT SET CAT_NAME = @CAT_NAME WHERE id = @ID

************************************************************
************************Silme işlemi******************

	CREATE PROCEDURE CAT_DELET
	@ID int 
	AS
	Delete   T_CAT where id  = @ID
 
************************************************************
************************Arama işlemi******************

  CREATE PROCEDURE CAT_SEARCH
  @SEARCH varchar(100)

AS
	select * from  T_CAT where  CAT_NAME like '%'+ @SEARCH +'%'





















**************************************************************************************************************************************










**************Tüm KITABLAR tablosu işlemlerinin başlangıcı***
************************************************************
************************görüntüleme işlemi******************
ALTER PROCEDURE Pr_LoadKitablar
AS
    SELECT id, K_AD, YAZAR, KATEGORI, K_FIATI 
	FROM KITABLAR

************************************************************
************************görüntüleme işlemi******************
CREATE PROCEDURE EKLE_COMBO_BOX

AS
	select CAT_NAME from  T_CAT

************************************************************
************************ekleme işlemi******************
 CREATE PROCEDURE INSERT_COMBOBOX
  @K_AD nvarchar(50) ,
  @YAZAR nvarchar(50) ,
  @KATIGORI nvarchar(50) ,
  @K_FIATI nvarchar(50) ,
  @K_TARIH nvarchar(50) ,
  @DEGERLENDIRME   int	,
  @K_RESIM image 
AS
	insert into KITABLAR (K_AD ,YAZAR ,KATEGORI, K_FIATI , TARIH , DEGERLENDIRME, K_RESIM) 
	values( @K_AD ,@YAZAR , @KATIGORI , @K_FIATI , @K_TARIH , @DEGERLENDIRME, @K_RESIM)

************************************************************
 ************************güncelleme işlemi ******************
 ALTER PROCEDURE EDIT_KITAP
  @K_AD nvarchar(50) ,
  @YAZAR nvarchar(50) ,
  @KATIGORI nvarchar(50) ,
  @K_FIATI nvarchar(50) ,
  @K_TARIH nvarchar(50) ,
  @DEGERLENDIRME   int	,
  @K_RESIM image ,
@ID int
AS
UPDATE KITABLAR SET K_AD = @K_AD , YAZAR = @YAZAR , KATEGORI = @KATIGORI , TARIH = @K_TARIH, DEGERLENDIRME =@DEGERLENDIRME , K_RESIM = @K_RESIM WHERE id = @ID

******************************************************************
************************güncelleme işlemi ******************

 CREATE PROCEDURE SELECT_KITAPLAR
	@ID int
AS
select K_AD ,YAZAR ,KATEGORI, K_FIATI , TARIH , DEGERLENDIRME , K_RESIM from KITABLAR where id = @ID

******************************************************************
************************güncelleme işlemi ******************
  CREATE PROCEDURE UPDATE_KITAPLAR
  
  @ID int ,
  @K_AD nvarchar(50) ,
  @YAZAR nvarchar(50) ,
  @KATIGORI nvarchar(50) ,
  @K_FIATI nvarchar(50) ,
  @K_TARIH nvarchar(50) ,
  @DEGERLENDIRME   int	,
  @K_RESIM image 

AS
	UPDATE KITABLAR SET K_AD = @K_AD , YAZAR = @YAZAR , KATEGORI = @KATIGORI , TARIH = @K_TARIH, DEGERLENDIRME =@DEGERLENDIRME , K_RESIM = @K_RESIM WHERE id = @ID

******************************************************************
************************Silme işlemi******************
 CREATE PROCEDURE DELTE_KITAPLAR
  @ID int
AS
	Delete KITABLAR  where id = @ID   


******************************************************************
************************Arama işlemi******************
 CREATE PROCEDURE KITAPLAR_SEARCH
  @SEARCH varchar(100)

AS

	select K_AD ,YAZAR ,KATEGORI, K_FIATI , TARIH , DEGERLENDIRME  from  KITABLAR where  CONCAT(K_AD ,YAZAR ,KATEGORI, K_FIATI , TARIH , DEGERLENDIRME) like '%'+ @SEARCH +'%'

/*CONCAT fonksiyonu, "KITAPLAR" tablosundaki birkaç alanı birleştirmek için kullanılıyor*/











**************************************************************************************************************************************









**************Tüm Öğrenci tablosu işlemlerinin başlangıcı***
******************************************************************
************************görüntüleme işlemi******************

  CREATE PROCEDURE Pr_LoadOGRENCILER
  AS  
select OGRENCI_NO , AD , ADRES ,TELEFON , EMAIL  from OGRENCILER

******************************************************************
************************ekleme işlemi******************
CREATE PROCEDURE INSERT_OGRENCI_YENI
  @OGRENCI_NO nvarchar(50) ,
  @AD nvarchar(50) ,
  @ADRES      nvarchar(50) ,
  @TELEFON    nvarchar(50) ,
  @EMAIL     nvarchar(50) ,
  @BULUM      nvarchar(150)	,
  @RESIM image 
AS
	insert into OGRENCILER(OGRENCI_NO ,AD, ADRES , TELEFON ,EMAIL ,BULUM, RESIM)
	values(@OGRENCI_NO,@AD,@ADRES,@TELEFON ,@EMAIL ,@BULUM, @RESIM)

******************************************************************
************************güncelleme işlemi ******************
  CREATE PROCEDURE SELECT_OGRENCI_YENI
  @ID int
  AS  
select OGRENCI_NO ,AD, ADRES , TELEFON ,EMAIL ,BULUM, RESIM  from OGRENCILER where id =@ID

******************************************************************
************************görüntüleme işlemi******************
CREATE PROCEDURE UPDATE_OGRENCILER
  
  @ID int ,
  @OGRENCI_NO  nvarchar(50),
  @AD nvarchar(50) ,
  @ADRES nvarchar(50) ,
  @TELEFON nvarchar(50) ,
  @EMAIL nvarchar(50) ,
  @BULUM nvarchar(50) ,
  @RESIM   image 
AS
	UPDATE OGRENCILER SET OGRENCI_NO = @OGRENCI_NO , AD = @AD , ADRES = @ADRES , TELEFON = @TELEFON , EMAIL = @EMAIL, BULUM =@BULUM , RESIM = @RESIM WHERE id = @ID

******************************************************************
************************Silme işlemi******************
  CREATE PROCEDURE DELTE_OGREMCILER
  @ID int
AS
	Delete OGRENCILER  where id = @ID 

******************************************************************
************************Arama işlemi******************
  CREATE PROCEDURE OGRENCILER_SEARCH
  @SEARCH varchar(100)

AS

	select  OGRENCI_NO,AD ,ADRES, TELEFON , EMAIL , BULUM   from  OGRENCILER where  CONCAT(OGRENCI_NO,AD ,ADRES, TELEFON , EMAIL , BULUM) like '%'+ @SEARCH +'%'

/*CONCAT fonksiyonu, "OGRENCILER" tablosundaki birkaç alanı birleştirmek için kullanılıyor*/

**************************************************************************************************************************************

**************Tüm EMANET tablosu işlemlerinin başlangıcı***
************************Silme işlemi******************


  CREATE PROCEDURE Pr_LOAD_EMANET

AS
	select * from EMANET
************************Silme işlemi******************
   CREATE PROCEDURE Pr_LOAD_OGRENCILER_EMANET

AS
	select id, AD  from OGRENCILER


CREATE PROCEDURE Pr_LOAD_KITAPLAR_EMANET
************************Silme işlemi******************
AS
	select id,K_AD  from KITABLAR

 CREATE PROCEDURE INSERT_EMANET
  @OGRENCI_ADI     nvarchar(50) ,
  @KITAP_ADI       nvarchar(50) ,
  @ALMA_TARIH      nvarchar(50) ,
  @GETIRME_TARIH    nvarchar(50) ,
  @FIAT             nvarchar(50) 

AS
	insert into EMANET values(@OGRENCI_ADI,@KITAP_ADI,@ALMA_TARIH,@GETIRME_TARIH ,@FIAT)


 CREATE PROCEDURE UPDATE_EMANET
  @OGRENCI_ADI     nvarchar(50) ,
  @KITAP_ADI       nvarchar(50) ,
  @ALMA_TARIH      nvarchar(50) ,
  @GETIRME_TARIH    nvarchar(50) ,
  @FIAT             nvarchar(50) ,
  @ID    int

AS
	update EMANET set  OGRENCI_ADI = @OGRENCI_ADI , KITAP_ADI =@KITAP_ADI , ALMA_TARIH =@ALMA_TARIH , GETIRME_TARIH = @GETIRME_TARIH , FIAT =@FIAT where id = @ID   

CREATE PROCEDURE Pr_DELET_EMANET
@ID int
AS
 delete EMANET where id=@ID

 ************************Arama işlemi******************
  ALTER PROCEDURE EMANET_SEARCH
  @SEARCH varchar(100)

AS

	select id , OGRENCI_ADI ,KITAP_ADI , FIAT , ALMA_TARIH ,GETIRME_TARIH from EMANET where  CONCAT(OGRENCI_ADI,KITAP_ADI, FIAT , ALMA_TARIH , GETIRME_TARIH) like '%'+ @SEARCH +'%'

/*CONCAT fonksiyonu, "OGRENCILER" tablosundaki birkaç alanı birleştirmek için kullanılıyor*/
 
 
 
 **************************************************************************************************************************************

**************Tüm KULANCILAR tablosu işlemlerinin başlangıcı***
 
 ALTER PROCEDURE Pr_LOAD_KULLANCLAR

 AS

select id ,  AD , KULLANCI_AD , SIFRE , durum from  KULANCILAR


 ************************Silme işlemi******************
ALTER PROCEDURE Pr_LOAD_KITAPLAR_EMANET
AS
	select id,K_AD  from KITABLAR
	
 ************************Silme işlemi******************

CREATE PROCEDURE Pr_LOAD_KULLANI

 AS

select id ,  AD , KULLANCI_AD , SIFRE , YETKILER from  KULANCILAR

 ************************Silme işlemi******************
 ALTER PROCEDURE INSERT_KULLANCILAR
  @AD				nvarchar(50) ,
  @KULLANCI_ADI     nvarchar(50) ,
  @SIFRE			nvarchar(50) ,
  @YETKILER         nvarchar(50) ,
  @durum		    nvarchar(50) 


AS
	insert into KULANCILAR values(@AD,@KULLANCI_ADI,@SIFRE,@YETKILER,@durum)


	************************Silme işlemi******************

 CREATE PROCEDURE SELECT_KULLANCILAR
	@ID int
AS
select AD ,KULLANCI_AD ,SIFRE, YETKILER from KULANCILAR where id = @ID



************************Silme işlemi******************

ALTER PROCEDURE Pr_Load_Kullancilar
  @AD				nvarchar(50) ,
  @KULLANCI_ADI     nvarchar(50) ,
  @SIFRE			nvarchar(50) ,
  @YETKILER         nvarchar(50) ,
  @ID int


AS
	update  KULANCILAR SET AD = @AD , KULLANCI_AD = @KULLANCI_ADI , SIFRE = @SIFRE ,YETKILER = @YETKILER  where id = @ID 

************************Silme işlemi******************
  CREATE PROCEDURE DELTE_KULLANCILAR
  @ID int
AS
	Delete KULANCILAR  where id = @ID 

 ************************Arama işlemi******************
 CREATE PROCEDURE KULLANCILAR_SEARCH
  @SEARCH varchar(100)

AS

	select id , AD ,KULLANCI_AD , SIFRE , YETKILER from KULANCILAR where  CONCAT(id,AD,KULLANCI_AD,SIFRE,YETKILER ) like '%'+ @SEARCH +'%'

/*CONCAT fonksiyonu, "OGRENCILER" tablosundaki birkaç alanı birleştirmek için kullanılıyor*/
 


ALTER PROCEDURE  Pr_PROGRAM_CIKIS

AS

update  KULANCILAR SET durum = 'False'  where id=id
**************************************************************************************************************************************
 */


ALTER PROCEDURE Pr_GIRIS_YAP 
@KULLANCI_ADI   nvarchar(50) ,
@SIFRE          nvarchar(50)


AS
select  AD, KULLANCI_AD ,SIFRE,YETKILER from  KULANCILAR   where  KULLANCI_AD =@KULLANCI_ADI AND SIFRE = @SIFRE


ALTER PROCEDURE Pr_GIRIS_YAP_UPDATE 

@KULLANCI_ADI   nvarchar(50) ,
@SIFRE          nvarchar(50) 

AS
update KULANCILAR SET durum = 'True'  Where KULLANCI_AD = @KULLANCI_ADI   AND SIFRE = @SIFRE