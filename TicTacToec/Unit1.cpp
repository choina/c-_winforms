//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
char p[9];
int kroki_p;
int pola[9];
int los[9];
int g=0;
Plansza::Plansza()
{
  Form1->pole1->Picture->LoadFromFile("img/nic.bmp");
  Form1->pole2->Picture->LoadFromFile("img/nic.bmp");
  Form1->pole3->Picture->LoadFromFile("img/nic.bmp");
  Form1->pole4->Picture->LoadFromFile("img/nic.bmp");
  Form1->pole5->Picture->LoadFromFile("img/nic.bmp");
  Form1->pole6->Picture->LoadFromFile("img/nic.bmp");
  Form1->pole7->Picture->LoadFromFile("img/nic.bmp");
  Form1->pole8->Picture->LoadFromFile("img/nic.bmp");
  Form1->pole9->Picture->LoadFromFile("img/nic.bmp");

  // n=nic|o=kółko|x=krzyżyk
  p[0]='n'; p[3]='n'; p[6]='n';
  p[1]='n'; p[4]='n'; p[7]='n';
  p[2]='n'; p[5]='n'; p[8]='n';


  Form1->pole1->Enabled = true;
  Form1->pole2->Enabled = true;
  Form1->pole3->Enabled = true;
  Form1->pole4->Enabled = true;
  Form1->pole5->Enabled = true;
  Form1->pole6->Enabled = true;
  Form1->pole7->Enabled = true;
  Form1->pole8->Enabled = true;
  Form1->pole9->Enabled = true;
}

void Plansza::ruch_gracza(int a)
{
    switch(a){
      case 1:
      Form1 -> pole1 -> Picture -> LoadFromFile("img/o.bmp");
      p[0]='o';
      Form1 -> pole1 -> Enabled=false;
        ruch_kompa();
      break;
      case 2:
      Form1 -> pole2 -> Picture -> LoadFromFile("img/o.bmp");
      p[1]='o';
      Form1 -> pole2 -> Enabled=false;
      pola[1]=2;
        ruch_kompa();
      break;
      case 3:
      Form1 -> pole3 -> Picture -> LoadFromFile("img/o.bmp");
      p[2]='o';
      Form1 -> pole3 -> Enabled=false;
      pola[2]=3;
        ruch_kompa();
      break;
      case 4:
      Form1 -> pole4 -> Picture -> LoadFromFile("img/o.bmp");
      p[3]='o';
      Form1 -> pole4 -> Enabled=false;
      pola[3]=4;
        ruch_kompa();
      break;
      case 5:
      Form1 -> pole5 -> Picture -> LoadFromFile("img/o.bmp");
      p[4]='o';
      Form1 -> pole5 -> Enabled=false;
      pola[4]=5;
        ruch_kompa();
      break;
      case 6:
      Form1 -> pole6 -> Picture -> LoadFromFile("img/o.bmp");
      p[5]='o';
      Form1 -> pole6 -> Enabled=false;
      pola[5]=6;
        ruch_kompa();
      break;
      case 7:
      Form1 -> pole7-> Picture -> LoadFromFile("img/o.bmp");
      p[6]='o';
      Form1 -> pole7 -> Enabled=false;
      pola[6]=7;
        ruch_kompa();
      break;
      case 8:
      Form1 -> pole8 -> Picture -> LoadFromFile("img/o.bmp");
      p[7]='o';
      Form1 -> pole8 -> Enabled=false;
      pola[7]=8;
        ruch_kompa();
      break;
      case 9:
      Form1 -> pole9 -> Picture -> LoadFromFile("img/o.bmp");
      p[8]='o';
      Form1 -> pole9 -> Enabled=false;
      pola[8]=9;
        ruch_kompa();
      break;
  }
}
int losuj()
{
 srand( time( NULL ) );
 int liczba;
 liczba=(rand()%9)+1;
 return liczba;
}
void Plansza::ruch_kompa(){
int pole;
pole=losuj();
while(p[pole]!='n')
{
pole=losuj();
}
Form1 -> Label1 -> Caption=pole;
switch(pole)
{
 case 1:
 Form1 -> pole1 -> Picture -> LoadFromFile("img/x.bmp");
 p[0]='x';
 Form1 -> pole1 -> Enabled=false;
 break;
  case 2:
 Form1 -> pole2 -> Picture -> LoadFromFile("img/x.bmp");
 p[1]='x';
 Form1 -> pole2 -> Enabled=false;
 break;
  case 3:
 Form1 -> pole3 -> Picture -> LoadFromFile("img/x.bmp");
 p[2]='x';
 Form1 -> pole3 -> Enabled=false;
 break;
  case 4:
 Form1 -> pole4 -> Picture -> LoadFromFile("img/x.bmp");
 p[3]='x';
 Form1 -> pole4 -> Enabled=false;
 break;
  case 5:
 Form1 -> pole5 -> Picture -> LoadFromFile("img/x.bmp");
 p[4]='x';
 Form1 -> pole5 -> Enabled=false;
 break;
  case 6:
 Form1 -> pole6 -> Picture -> LoadFromFile("img/x.bmp");
 p[5]='x';
 Form1 -> pole6 -> Enabled=false;
 break;
  case 7:
 Form1 -> pole7 -> Picture -> LoadFromFile("img/x.bmp");
 p[6]='x';
 Form1 -> pole7 -> Enabled=false;
 break;
  case 8:
 Form1 -> pole8 -> Picture -> LoadFromFile("img/x.bmp");
 p[7]='x';
 Form1 -> pole8 -> Enabled=false;
 break;
  case 9:
 Form1 -> pole9 -> Picture -> LoadFromFile("img/x.bmp");
 p[8]='x';
 Form1 -> pole9 -> Enabled=false;
 break;

}
}
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
: TForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TForm1::pole1Click(TObject *Sender)
{
  p1.ruch_gracza(1);

}
//---------------------------------------------------------------------------

void __fastcall TForm1::pole2Click(TObject *Sender)
{
  p1.ruch_gracza(2);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::pole3Click(TObject *Sender)
{
  p1.ruch_gracza(3);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::pole4Click(TObject *Sender)
{
  p1.ruch_gracza(4);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::pole5Click(TObject *Sender)
{
  p1.ruch_gracza(5);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::pole6Click(TObject *Sender)
{
  p1.ruch_gracza(6);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::pole7Click(TObject *Sender)
{
  p1.ruch_gracza(7);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::pole8Click(TObject *Sender)
{
  p1.ruch_gracza(8);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::pole9Click(TObject *Sender)
{
  p1.ruch_gracza(9);
}
//---------------------------------------------------------------------------
