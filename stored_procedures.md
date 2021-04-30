### Yazar Tablosu İçin
create procedure Yazar_Ekle(@ad varchar(50),@soyad varchar(50),@biyografi varchar(max),@foto varchar(500))
	as
		insert into Yazarlar(YazarAdi,YazarSoyadi,YazarBiyografisi,YazarFotoUrl) values(@ad,@soyad,@biyografi,@foto)
	
create procedure Yazar_Guncelle(@id int,@ad varchar(50),@soyad varchar(50),@biyografi varchar(max),@foto varchar(500))
	as
		update Yazarlar set YazarAdi=@ad,YazarSoyadi=@soyad,YazarBiyografisi=@biyografi,YazarFotoUrl=@foto where Id=@id

create procedure Yazar_Sil(@id int)
	as
		delete from Yazarlar where Id = @id

create procedure Yazar_Tablosu 
	as
		select Id,YazarAdi,YazarSoyadi,YazarBiyografisi,YazarFotoUrl from Yazarlar

### Editör Tablosu İçin
create procedure Editor_Ekle(@ad varchar(50),@soyad varchar(50))
	as
		insert into Editorler(EditorAdi,EditorSoyadi) values(@ad,@soyad)
	
create procedure Editor_Guncelle(@id int,@ad varchar(50),@soyad varchar(50))
	as
		update Editorler set EditorAdi=@ad,EditorSoyadi=@soyad where Id=@id

create procedure Editor_Sil(@id int)
	as
		delete from Yazarlar where Id = @id

create procedure Editor_Tablosu 
	as
		select Id,EditorAdi,EditorSoyadi from Editorler
### Yorum Tablosu için
create procedure Yorumlar_Tablosu
	as
		select Id,Ad,Soyad,Mesaj,YorumTarihi from Yorumlar

create procedure Yorum_Sil(@id int)
	as
		delete from Yorumlar where Id=@id