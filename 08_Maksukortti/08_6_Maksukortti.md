# 06_Maksukortti

Tee luokan Paaohjelma main-metodiin koodi, joka sisältää seuraavan tapahtumasarjan:

	Luo Pekan kortti. Kortin alkusaldo on 20 euroa
	Luo Matin kortti. Kortin alkusaldo on 30 euroa
	Pekka syö maukkaasti
	Matti syö edullisesti
	Korttien arvot tulostetaan (molemmat omalle rivilleen, rivin alkuun kortin omistajan nimi)
	Pekka lataa rahaa 20 euroa
	Matti syö maukkaasti
	Korttien arvot tulostetaan (molemmat omalle rivilleen, rivin alkuun kortin omistajan nimi)
	Pekka syö edullisesti
	Pekka syö edullisesti
	Matti lataa rahaa 50 euroa
	Korttien arvot tulostetaan (molemmat omalle rivilleen, rivin alkuun kortin omistajan nimi)

Pääohjelman runko on seuraava:
```c#
public class Main { 
	public static void main(String[] args) { 
		Maksukortti pekanKortti = new Maksukortti(20); 
		Maksukortti matinKortti = new Maksukortti(30);
		// kirjoita koodia tähän
	}
}
```
Ohjelman tulisi tuottaa seuraava tulostus:

Pekka: Kortilla on rahaa 15.4 euroa  
Matti: Kortilla on rahaa 27.4 euroa  
Pekka: Kortilla on rahaa 35.4 euroa  
Matti: Kortilla on rahaa 22.799999999999997 euroa  
Pekka: Kortilla on rahaa 30.199999999999996 euroa  
Matti: Kortilla on rahaa 72.8 euroa
