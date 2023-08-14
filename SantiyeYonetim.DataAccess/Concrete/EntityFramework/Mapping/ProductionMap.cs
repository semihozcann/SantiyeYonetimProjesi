using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SantiyeYonetim.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.DataAccess.Concrete.EntityFramework.Mapping
{
    public class ProductionMap : IEntityTypeConfiguration<Production>
    {
        public void Configure(EntityTypeBuilder<Production> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.ProductionRowNumber);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(150);
            builder.Property(p => p.Description).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(250);

            builder.ToTable("Productions");

            builder.HasData(
                new Production
                {
                    Id = 1,
                    ProductionRowNumber = 1,
                    Name = "HAFRİYAT",
                    Description = "Description",
                },
                new Production
                {
                    Id = 2,
                    ProductionRowNumber = 1,
                    Name = "DOLGU",
                    Description = "Description",
                },



                new Production
                {
                    Id = 3,
                    ProductionRowNumber = 1,
                    Name = "GROBETON",
                    Description = "Description",
                },
                new Production
                {
                    Id = 4,
                    ProductionRowNumber = 1,
                    Name = "TEMEL MANTOLAMA",
                    Description = "Description",
                },
                new Production
                {
                    Id = 5,
                    ProductionRowNumber = 1,
                    Name = "TEMEL BETONU",
                    Description = "Description",
                },
                new Production
                {
                    Id = 6,
                    ProductionRowNumber = 1,
                    Name = "BODRUM BETONARME",
                    Description = "Description",
                },
                new Production
                {
                    Id = 7,
                    ProductionRowNumber = 1,
                    Name = "BODRUM DRENAJ",
                    Description = "Description",
                },
                new Production
                {
                    Id = 8,
                    ProductionRowNumber = 1,
                    Name = "BODRUM PERDESİ İZOLASYONU",
                    Description = "Description",
                },
                new Production
                {
                    Id = 9,
                    ProductionRowNumber = 1,
                    Name = "BETONARME İMALATI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 10,
                    ProductionRowNumber = 1,
                    Name = "PREKAST İMALATLARI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 11,
                    ProductionRowNumber = 1,
                    Name = "MERDİVEN PREKAST MONTAJI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 12,
                    ProductionRowNumber = 1,
                    Name = "DIŞ CEPHE PREKAST MONTAJI",
                    Description = "Description",
                },





                new Production
                {
                    Id = 13,
                    ProductionRowNumber = 1,
                    Name = "ÇATI İŞLERİ",
                    Description = "Description",
                },
                new Production
                {
                    Id = 14,
                    ProductionRowNumber = 1,
                    Name = "İÇ DIŞ ÖRME DUVARLAR",
                    Description = "Description",
                },
                new Production
                {
                    Id = 15,
                    ProductionRowNumber = 1,
                    Name = "KARA SIVA ( İÇ - DIŞ )",
                    Description = "Description",
                },
                new Production
                {
                    Id = 16,
                    ProductionRowNumber = 1,
                    Name = "İÇ CEPHE ISI İZOLASYONU",
                    Description = "Description",
                },
                new Production
                {
                    Id = 17,
                    ProductionRowNumber = 1,
                    Name = "İÇ SIVA ( ALÇI)",
                    Description = "Description",
                },
                new Production
                {
                    Id = 18,
                    ProductionRowNumber = 1,
                    Name = "DIŞ CEPHE TAMİRATI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 19,
                    ProductionRowNumber = 1,
                    Name = "PREKAST BİRLEŞİM İZOLASYONU",
                    Description = "Description",
                },
                new Production
                {
                    Id = 20,
                    ProductionRowNumber = 1,
                    Name = "İÇ BOYA MACUNU",
                    Description = "Description",
                },
                new Production
                {
                    Id = 21,
                    ProductionRowNumber = 1,
                    Name = "KARTONPİYER",
                    Description = "Description",
                },
                new Production
                {
                    Id = 22,
                    ProductionRowNumber = 1,
                    Name = "DIŞ CEPHE ISI İZOLASYONU (MANTOLAMA)",
                    Description = "Description",
                },
                new Production
                {
                    Id = 23,
                    ProductionRowNumber = 1,
                    Name = "ŞAP + SES İZOLASYONU",
                    Description = "Description",
                },
                new Production
                {
                    Id = 24,
                    ProductionRowNumber = 1,
                    Name = "MERMER DENİZLİK",
                    Description = "Description",
                },
                new Production
                {
                    Id = 25,
                    ProductionRowNumber = 1,
                    Name = "FRANSIZ BALKON KORKULUK",
                    Description = "Description",
                },
                new Production
                {
                    Id = 26,
                    ProductionRowNumber = 1,
                    Name = "YANGIN MERDİVEN KORKULUK",
                    Description = "Description",
                },
                new Production
                {
                    Id = 27,
                    ProductionRowNumber = 1,
                    Name = "FAYANS İMALATI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 28,
                    ProductionRowNumber = 1,
                    Name = "MERMER İMALATI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 29,
                    ProductionRowNumber = 1,
                    Name = "SERAMİK İMALATLARI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 30,
                    ProductionRowNumber = 1,
                    Name = "PVC DOĞRAMA MONTAJI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 31,
                    ProductionRowNumber = 1,
                    Name = "CAM MONTAJI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 32,
                    ProductionRowNumber = 1,
                    Name = "MENFEZ MONTAJLARI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 33,
                    ProductionRowNumber = 1,
                    Name = "İÇ BOYA ASTARI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 34,
                    ProductionRowNumber = 1,
                    Name = "DIŞ BOYA",
                    Description = "Description",
                },
                new Production
                {
                    Id = 35,
                    ProductionRowNumber = 1,
                    Name = "MERDİVEN KORKULUĞU",
                    Description = "Description",
                },
                new Production
                {
                    Id = 36,
                    ProductionRowNumber = 1,
                    Name = "DAİRE GİRİŞ KAPILARI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 37,
                    ProductionRowNumber = 1,
                    Name = "ASMA TAVAN",
                    Description = "Description",
                },
                new Production
                {
                    Id = 38,
                    ProductionRowNumber = 1,
                    Name = "İÇ BOYA SON KAT",
                    Description = "Description",
                },
                new Production
                {
                    Id = 39,
                    ProductionRowNumber = 1,
                    Name = "DAİRE İÇ KAPILARI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 40,
                    ProductionRowNumber = 1,
                    Name = "ŞAFT KAPAK ve DOLAPLARI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 41,
                    ProductionRowNumber = 1,
                    Name = "MUTFAK DOLAPLARI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 42,
                    ProductionRowNumber = 1,
                    Name = "BANYO DOLAPLARI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 43,
                    ProductionRowNumber = 1,
                    Name = "PORTMANTO ve GÖMME DOLAP",
                    Description = "Description",
                },
                new Production
                {
                    Id = 44,
                    ProductionRowNumber = 1,
                    Name = "ANKASTRE BEYAZ EŞYA",
                    Description = "Description",
                },
                new Production
                {
                    Id = 45,
                    ProductionRowNumber = 1,
                    Name = "MDF SÜPÜRGELİK",
                    Description = "Description",
                },
                new Production
                {
                    Id = 46,
                    ProductionRowNumber = 1,
                    Name = "PARKE KAPLAMA",
                    Description = "Description",
                },
                new Production
                {
                    Id = 47,
                    ProductionRowNumber = 1,
                    Name = "KABA TEMİZLİK",
                    Description = "Description",
                },
                new Production
                {
                    Id = 48,
                    ProductionRowNumber = 1,
                    Name = "KABA TEMİZLİK",
                    Description = "Description",
                },
                new Production
                {
                    Id = 49,
                    ProductionRowNumber = 1,
                    Name = "HALI KAPLAMA",
                    Description = "Description",
                },
                new Production
                {
                    Id = 50,
                    ProductionRowNumber = 1,
                    Name = "DUŞAKABİN MONTAJI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 51,
                    ProductionRowNumber = 1,
                    Name = "BİNA GİRİŞ İMALATLARI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 52,
                    ProductionRowNumber = 1,
                    Name = "İNCE TEMİZLİK",
                    Description = "Description",
                },







                new Production
                {
                    Id = 53,
                    ProductionRowNumber = 1,
                    Name = "ELEKTRİK İMALATLARI (1. GRUP)",
                    Description = "Description",
                },
                new Production
                {
                    Id = 54,
                    ProductionRowNumber = 1,
                    Name = "ELEKTRİK ARMATÜR MONTAJI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 55,
                    ProductionRowNumber = 1,
                    Name = "ELEKTRİK İMALATLARI (2. GRUP)",
                    Description = "Description",
                },
                new Production
                {
                    Id = 56,
                    ProductionRowNumber = 1,
                    Name = "ELEKTRİK TEST",
                    Description = "Description",
                },






                new Production
                {
                    Id = 57,
                    ProductionRowNumber = 1,
                    Name = "SIHHİ TESİSAT",
                    Description = "Description",
                },
                new Production
                {
                    Id = 58,
                    ProductionRowNumber = 1,
                    Name = "YANGIN TESİSATI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 59,
                    ProductionRowNumber = 1,
                    Name = "KALORİFER TESİSATI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 60,
                    ProductionRowNumber = 1,
                    Name = "ASANSÖR RAY MONTAJI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 61,
                    ProductionRowNumber = 1,
                    Name = "ASANSÖR KAPI KASA MONTAJI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 62,
                    ProductionRowNumber = 1,
                    Name = "DOĞALGAZ TESİSATI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 63,
                    ProductionRowNumber = 1,
                    Name = "ASANSÖR MAKİNE MOTOR",
                    Description = "Description",
                },
                new Production
                {
                    Id = 64,
                    ProductionRowNumber = 1,
                    Name = "RADYATÖR PANEL MONTAJI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 65,
                    ProductionRowNumber = 1,
                    Name = "VİTRİFİYE ARMATÜR MONTAJI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 66,
                    ProductionRowNumber = 1,
                    Name = "ASANSÖR KABİN MONTAJI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 67,
                    ProductionRowNumber = 1,
                    Name = "MEKANİK TEST",
                    Description = "Description",
                }


                );
        }
    }
}
