var Oznak="";
var g=1;
var i=0;
var m=0;
var p=0;
var znak="";
var wynik=0;
var pomoc=0;
var dlg=0;
var waznosc=0;
var liczba=new Array();
function test()
{
	document.getElementById('test').innerHTML+=liczba[0]+"<br>";
	document.getElementById('test').innerHTML+=liczba[1]+"<br>";
	document.getElementById('test').innerHTML+=liczba[2]+"<br>";
	document.getElementById('test').innerHTML+=liczba[3]+"<br>";
	document.getElementById('test').innerHTML+=liczba[4]+"<br>";
	document.getElementById('test').innerHTML+=pomoc+"<br>";
	document.getElementById('test').innerHTML+=p+"<br>";
	document.getElementById('test').innerHTML+="wynik "+wynik+"<br>";
	document.getElementById('test').innerHTML+=Oznak+"<br>";
	document.getElementById('test').innerHTML+=g+"<br>";
	document.getElementById('test').innerHTML+=i+"<br>";
	document.getElementById('test').innerHTML+=m+"<br>";
	document.getElementById('test').innerHTML+=znak+"<br>";
	document.getElementById('test').innerHTML+=dlg+"<br>";
	document.getElementById('test').innerHTML+=waznosc+"<br>";
	document.getElementById('test').innerHTML+="-----------------------------------"+"<br>";
}
function usun()
{
	for(var i=0;i<liczba.length;i++)
	{
		delete liczba[i];
	}
	p=0;
	g=1;
	Oznak="";
	wynik=0;
	pomoc=0;
	document.getElementById('wysw').value;
}
function dodaj_liczbe(znak)
{
	liczba[i]=document.getElementById('wysw').value;
	i++;
	switch(znak)
	{
		case 1:
			liczba[i]="+";
			i++;
		break;
		case 2:
			liczba[i]="-";
			i++;
		break;
		case 3:
			liczba[i]="*";
			i++
		break;
		case 4:
			liczba[i]="/";
			i++
		break;
		case 5:
			liczba[i]="%";
			i++
		break;
		case 6:
			liczba[i]="pier";
			i++
		break;
		case 7:
			liczba[i]="^";
			i++
		break;
	}
}
function dzialanie()
{
	wynik=parseFloat(liczba[0]);
	for(var i=0;i<p;i++)
	{
		switch(liczba[g])
		{
			case '+':
				wynik+=parseFloat(liczba[g+1]);
			break;
			case '-':
				wynik-=parseFloat(liczba[g+1]);
			break;
			case '*':
				wynik*=parseFloat(liczba[g+1]);
			break;
			case '/':
				wynik/=parseFloat(liczba[g+1]);
			break;
			case '%':
				wynik=parseFloat(liczba[g-1])*parseFloat(liczba[g+1])/100;
			break;
		}
	g=g+2;
	}
	return wynik;
	}

function silnia(liczba)
{
	if(liczba<2)
	{
		return wynik=1;
	} 
	else
	{
		wynik = (liczba* silnia(liczba-1));
		return wynik;
	}
}
function pierwiastek()
{
	if(liczba[1]=="pier")
	{
		wynik= Math.sqrt(liczba[g-1]);
		return wynik;
	}
	else return 0;
}
function potega()
{
wynik = 1;
while(liczba[2]--)
{
	wynik*=liczba[0];
}
return wynik;
}
function znakk(c)
{
	if(Oznak=="z")
	{
		document.getElementById('wysw').value=c;
		Oznak="";
	}
	else
		document.getElementById('wysw').value+=c;
}
function glowna(x)
{
	
	switch(x.id)
	{
		case 'pierwiastek':
			Oznak="z";
			dodaj_liczbe(6);
			pierwiastek();
			document.getElementById('wysw').value=wynik;
			p++;
		break;
	}
	var licz = 0;
	switch(x.value)
	{
	case '1':
		znakk(1);
	break;
	case '2':
		znakk(2);
	break;
	case '3':
		znakk(3);
	break;
	case '4':
		znakk(4);
	break;
	case '5':
		znakk(5);
	break;
	case '6':
		znakk(6);
	break;
	case '7':
		znakk(7);
	break;
	case '8':
		znakk(8);
	break;
	case '9':
		znakk(9);
	break;
	case '0':
		znakk(0);
	break;
	case '.':
		document.getElementById('wysw').value+='.';
	break;
	case '+':
		Oznak="z";
		dodaj_liczbe(1);
		p++;
	break;
	case '-':
		Oznak="z";
		dodaj_liczbe(2);
		p++;
	break;
	case '*':
		Oznak="z";
		dodaj_liczbe(3);
		p++;
	break;
	case '/':
		Oznak="z";
		dodaj_liczbe(4);
		p++;
	break;
	case '!':
		Oznak="z";
		dodaj_liczbe();
		silnia(liczba[i-1]);
		document.getElementById('wysw').value=wynik;
		p++;
	break;
	case '%':
		Oznak="z";
		dodaj_liczbe(5);
		p++;
	break;
	case '^':
		Oznak="z";
		dodaj_liczbe(7);
	break;
	case '=':
		dodaj_liczbe();
		dzialanie();
		if(liczba[1]=="^")
		{
			potega();
		}
		document.getElementById('wysw').value=wynik;
		i=0;
		break;
}
}