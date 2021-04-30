### Editör Eklendikten Sonra Çalışacak Trigger<hr>
create trigger Editor_Ekleme_Durumu on Editorler after insert
as
	declare @hesapId int,@editorId int,@editorAdi varchar(50),@editorSoyadi varchar(50),@username varchar(50),@password varchar(50)
	begin
	select @editorAdi = EditorAdi from inserted
	select @editorSoyadi = EditorSoyadi from inserted
   select @editorId = Id from inserted

   set @username = @editorAdi+ '_' + @editorSoyadi
   set @password = @editorAdi+ '_' + @editorSoyadi + cast(@editorId as varchar(3))

insert into Hesaplar(Username,Password) values(@username,@password)

select @hesapId=Id from Hesaplar where Password = @password

insert into HesapHareketleri(IslemTarihi,EditorId,HesapId) values(CURRENT_TIMESTAMP,@editorId,@hesapId)
	end
### Editör Güncellendikten Sonra Çalışacak Trigger<hr>
create trigger Editor_Guncelleme_Durumu on Editorler after update
as
	declare @hesapId int,@editorId int,@editorAdi varchar(50),@editorSoyadi varchar(50),@username varchar(50),@password varchar(50)
	begin
	select @editorAdi = EditorAdi from inserted
	select @editorSoyadi = EditorSoyadi from inserted
	select @editorId = Id from inserted
	select @hesapId = HesapId from inserted

set @username = @editorAdi+ '_' + @editorSoyadi
		set @password = @editorAdi+ '_' + @editorSoyadi + cast(@editorId as varchar(3))

update Hesaplar set Username = @username,Password=@password where Id=@hesapId
	end
### Editör Silindikten Sonra Çalışacak Trigger<hr>
create trigger Editor_Silme_Durumu on Editorler after delete
as
	declare @hesapId int
	begin
	select @hesapId = HesapId from deleted
		
delete from Hesaplar where Id = @hesapId
	end
### Yazar Eklendikten Sonra Çalışacak Trigger<hr>
create trigger Yazar_Ekleme_Durumu on Yazarlar after insert as
	declare @hesapId int,@yazarId int,@yazarAdi varchar(50),@yazarSoyadi varchar(50),@username varchar(50),@password varchar(50)
	begin
		select @yazarAdi = YazarAdi from inserted
		select @yazarSoyadi = YazarSoyadi from inserted
		select @yazarId = Id from inserted

set @username = @yazarAdi+ '_' + @yazarSoyadi
		set @password = @yazarAdi+ '_' + @yazarSoyadi + cast(@yazarId as varchar(3))

insert into Hesaplar(Username,Password) values(@username,@password)

select @hesapId=Id from Hesaplar where Password = @password

insert into HesapHareketleri(IslemTarihi,YazarId,HesapId) values(CURRENT_TIMESTAMP,@yazarId,@hesapId)
	end
### Yazar Güncellendikten Sonra Çalışacak Trigger<hr>
create trigger Yazar_Guncelleme_Durumu on Yazarlar after update as
	declare @hesapId int,@yazarId int,@yazarAdi varchar(50),@yazarSoyadi varchar(50),@username varchar(50),@password varchar(50)
	begin
		select @yazarAdi = YazarAdi from inserted
		select @yazarSoyadi = YazarSoyadi from inserted
		select @yazarId = Id from inserted
		select @hesapId = HesapId from inserted

set @username = @yazarAdi+ '_' + @yazarSoyadi
	set @password = @yazarAdi+ '_' + @yazarSoyadi + cast(@yazarId as varchar(3))

update Hesaplar set Username = @username,Password=@password where Id=@hesapId
	end
### Yazar Silindikten Sonra Çalışacak Trigger<hr>
create trigger Yazar_Silme_Durumu on Yazarlar after delete as
	declare @hesapId int
	begin
		select @hesapId = HesapId from deleted
		
delete from Hesaplar where Id = @hesapId
	end
### Hesap Oluşturma İsteği Geldikten Sonra Çalışacak Trigger<hr>
create trigger Hesap_Ekleme_Durumu on HesapHareketleri after insert as
	declare @editorId int,@yazarId int,@hesapId int
	begin
		select @editorId = EditorId from inserted
		select @yazarId = YazarId from inserted
		select @hesapId = HesapId from inserted

if(@yazarId is null)
			update Editorler set HesapId=@hesapId where Id = @editorId
		else
			update Yazarlar set HesapId=@hesapId where Id = @yazarId

end