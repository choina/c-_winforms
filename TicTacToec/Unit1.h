//---------------------------------------------------------------------------

#ifndef Unit1H
#define Unit1H
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <ExtCtrls.hpp>
//---------------------------------------------------------------------------
class Plansza{
public:
void ruch_gracza(int a);
Plansza::Plansza();
void ruch_kompa();
};

class TForm1 : public TForm
{
__published:	// IDE-managed Components
        TImage *pole8;
        TImage *pole5;
        TImage *pole1;
        TImage *pole3;
        TImage *pole4;
        TImage *pole2;
        TImage *pole6;
        TImage *pole9;
        TImage *pole7;
        TLabel *Label1;
        void __fastcall pole1Click(TObject *Sender);
        void __fastcall pole2Click(TObject *Sender);
        void __fastcall pole3Click(TObject *Sender);
        void __fastcall pole4Click(TObject *Sender);
        void __fastcall pole5Click(TObject *Sender);
        void __fastcall pole6Click(TObject *Sender);
        void __fastcall pole7Click(TObject *Sender);
        void __fastcall pole8Click(TObject *Sender);
        void __fastcall pole9Click(TObject *Sender);
private:          Plansza p1;
public:
        __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
