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
            builder.Property(p => p.ProductionTypeId);
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
                    ProductionTypeId = 1,
                    ProductionRowNumber = 1,
                    Name = "HAFRİYAT",
                    Description = "Description",
                },
                new Production
                {
                    Id = 2,
                    ProductionTypeId = 1,
                    ProductionRowNumber = 1,
                    Name = "DOLGU",
                    Description = "Description",
                },



                new Production
                {
                    Id = 3,
                    ProductionTypeId = 2,
                    ProductionRowNumber = 1,
                    Name = "GROBETON",
                    Description = "Description",
                },
                new Production
                {
                    Id = 4,
                    ProductionTypeId = 2,
                    ProductionRowNumber = 1,
                    Name = "TEMEL MANTOLAMA",
                    Description = "Description",
                },
                new Production
                {
                    Id = 5,
                    ProductionTypeId = 2,
                    ProductionRowNumber = 1,
                    Name = "TEMEL BETONU",
                    Description = "Description",
                },
                new Production
                {
                    Id = 6,
                    ProductionTypeId = 2,
                    ProductionRowNumber = 1,
                    Name = "BODRUM BETONARME",
                    Description = "Description",
                },
                new Production
                {
                    Id = 7,
                    ProductionTypeId = 2,
                    ProductionRowNumber = 1,
                    Name = "BODRUM DRENAJ",
                    Description = "Description",
                },
                new Production
                {
                    Id = 8,
                    ProductionTypeId = 2,
                    ProductionRowNumber = 1,
                    Name = "BODRUM PERDESİ İZOLASYONU",
                    Description = "Description",
                },
                new Production
                {
                    Id = 9,
                    ProductionTypeId = 2,
                    ProductionRowNumber = 1,
                    Name = "BETONARME İMALATI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 10,
                    ProductionTypeId = 2,
                    ProductionRowNumber = 1,
                    Name = "PREKAST İMALATLARI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 11,
                    ProductionTypeId = 2,
                    ProductionRowNumber = 1,
                    Name = "MERDİVEN PREKAST MONTAJI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 12,
                    ProductionTypeId = 2,
                    ProductionRowNumber = 1,
                    Name = "DIŞ CEPHE PREKAST MONTAJI",
                    Description = "Description",
                },





                new Production
                {
                    Id = 13,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "ÇATI İŞLERİ",
                    Description = "Description",
                },
                new Production
                {
                    Id = 14,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "İÇ DIŞ ÖRME DUVARLAR",
                    Description = "Description",
                },
                new Production
                {
                    Id = 15,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "KARA SIVA ( İÇ - DIŞ )",
                    Description = "Description",
                },
                new Production
                {
                    Id = 16,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "İÇ CEPHE ISI İZOLASYONU",
                    Description = "Description",
                },
                new Production
                {
                    Id = 17,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "İÇ SIVA ( ALÇI)",
                    Description = "Description",
                },
                new Production
                {
                    Id = 18,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "DIŞ CEPHE TAMİRATI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 19,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "PREKAST BİRLEŞİM İZOLASYONU",
                    Description = "Description",
                },
                new Production
                {
                    Id = 20,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "İÇ BOYA MACUNU",
                    Description = "Description",
                },
                new Production
                {
                    Id = 21,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "KARTONPİYER",
                    Description = "Description",
                },
                new Production
                {
                    Id = 22,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "DIŞ CEPHE ISI İZOLASYONU (MANTOLAMA)",
                    Description = "Description",
                },
                new Production
                {
                    Id = 23,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "ŞAP + SES İZOLASYONU",
                    Description = "Description",
                },
                new Production
                {
                    Id = 24,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "MERMER DENİZLİK",
                    Description = "Description",
                },
                new Production
                {
                    Id = 25,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "FRANSIZ BALKON KORKULUK",
                    Description = "Description",
                },
                new Production
                {
                    Id = 26,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "YANGIN MERDİVEN KORKULUK",
                    Description = "Description",
                },
                new Production
                {
                    Id = 27,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "FAYANS İMALATI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 28,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "MERMER İMALATI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 29,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "SERAMİK İMALATLARI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 30,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "PVC DOĞRAMA MONTAJI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 31,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "CAM MONTAJI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 32,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "MENFEZ MONTAJLARI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 33,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "İÇ BOYA ASTARI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 34,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "DIŞ BOYA",
                    Description = "Description",
                },
                new Production
                {
                    Id = 35,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "MERDİVEN KORKULUĞU",
                    Description = "Description",
                },
                new Production
                {
                    Id = 36,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "DAİRE GİRİŞ KAPILARI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 37,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "ASMA TAVAN",
                    Description = "Description",
                },
                new Production
                {
                    Id = 38,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "İÇ BOYA SON KAT",
                    Description = "Description",
                },
                new Production
                {
                    Id = 39,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "DAİRE İÇ KAPILARI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 40,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "ŞAFT KAPAK ve DOLAPLARI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 41,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "MUTFAK DOLAPLARI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 42,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "BANYO DOLAPLARI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 43,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "PORTMANTO ve GÖMME DOLAP",
                    Description = "Description",
                },
                new Production
                {
                    Id = 44,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "ANKASTRE BEYAZ EŞYA",
                    Description = "Description",
                },
                new Production
                {
                    Id = 45,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "MDF SÜPÜRGELİK",
                    Description = "Description",
                },
                new Production
                {
                    Id = 46,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "PARKE KAPLAMA",
                    Description = "Description",
                },
                new Production
                {
                    Id = 47,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "KABA TEMİZLİK",
                    Description = "Description",
                },
                new Production
                {
                    Id = 48,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "KABA TEMİZLİK",
                    Description = "Description",
                },
                new Production
                {
                    Id = 49,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "HALI KAPLAMA",
                    Description = "Description",
                },
                new Production
                {
                    Id = 50,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "DUŞAKABİN MONTAJI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 51,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "BİNA GİRİŞ İMALATLARI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 52,
                    ProductionTypeId = 3,
                    ProductionRowNumber = 1,
                    Name = "İNCE TEMİZLİK",
                    Description = "Description",
                },







                new Production
                {
                    Id = 53,
                    ProductionTypeId = 4,
                    ProductionRowNumber = 1,
                    Name = "ELEKTRİK İMALATLARI (1. GRUP)",
                    Description = "Description",
                },
                new Production
                {
                    Id = 54,
                    ProductionTypeId = 4,
                    ProductionRowNumber = 1,
                    Name = "ELEKTRİK ARMATÜR MONTAJI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 55,
                    ProductionTypeId = 4,
                    ProductionRowNumber = 1,
                    Name = "ELEKTRİK İMALATLARI (2. GRUP)",
                    Description = "Description",
                },
                new Production
                {
                    Id = 56,
                    ProductionTypeId = 4,
                    ProductionRowNumber = 1,
                    Name = "ELEKTRİK TEST",
                    Description = "Description",
                },






                new Production
                {
                    Id = 57,
                    ProductionTypeId = 5,
                    ProductionRowNumber = 1,
                    Name = "SIHHİ TESİSAT",
                    Description = "Description",
                },
                new Production
                {
                    Id = 58,
                    ProductionTypeId = 5,
                    ProductionRowNumber = 1,
                    Name = "YANGIN TESİSATI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 59,
                    ProductionTypeId = 5,
                    ProductionRowNumber = 1,
                    Name = "KALORİFER TESİSATI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 60,
                    ProductionTypeId = 5,
                    ProductionRowNumber = 1,
                    Name = "ASANSÖR RAY MONTAJI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 61,
                    ProductionTypeId = 5,
                    ProductionRowNumber = 1,
                    Name = "ASANSÖR KAPI KASA MONTAJI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 62,
                    ProductionTypeId = 5,
                    ProductionRowNumber = 1,
                    Name = "DOĞALGAZ TESİSATI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 63,
                    ProductionTypeId = 5,
                    ProductionRowNumber = 1,
                    Name = "ASANSÖR MAKİNE MOTOR",
                    Description = "Description",
                },
                new Production
                {
                    Id = 64,
                    ProductionTypeId = 5,
                    ProductionRowNumber = 1,
                    Name = "RADYATÖR PANEL MONTAJI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 65,
                    ProductionTypeId = 5,
                    ProductionRowNumber = 1,
                    Name = "VİTRİFİYE ARMATÜR MONTAJI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 66,
                    ProductionTypeId = 5,
                    ProductionRowNumber = 1,
                    Name = "ASANSÖR KABİN MONTAJI",
                    Description = "Description",
                },
                new Production
                {
                    Id = 67,
                    ProductionTypeId = 5,
                    ProductionRowNumber = 1,
                    Name = "MEKANİK TEST",
                    Description = "Description",
                }


                );
        }
    }
}
