using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnuthMorrisPratt.Tests
{
    public static class TestCasesGenerator
    {
        public static IEnumerable ExistsIn_TestCases
        {
            get
            {
                #region <|  A  |>

                yield return new TestCaseData(
                    A.___________________________________________________________________________________)
                    
                    .Returns(false);

                yield return new TestCaseData(
                    A.______________________________________________________________A)

                    .Returns(true);

                yield return new TestCaseData(
                    A.__________________________________A____________________________)

                    .Returns(true);

                yield return new TestCaseData(
                    A._________A________________A__________A____________A______A__________AA)

                    .Returns(true);

                yield return new TestCaseData(
                    A.___PATTERN___)

                    .Returns(true);

                yield return new TestCaseData(
                    A.A______________________________________________________________)

                    .Returns(true);

                yield return new TestCaseData(
                    A.A_A___AAAA____AAA____AAA___AAAAAAAAAAAAAAAAAAAAAAAAAAAAA)

                    .Returns(true);

                yield return new TestCaseData(
                    A.AAAA_________A___AAAA______A__________A________AAAAA____A______A__________AA)

                    .Returns(true);

                yield return new TestCaseData(
                    A.aaaaaaA)

                    .Returns(true);

                yield return new TestCaseData(
                    A.Aaaaaaaaaaaa)

                    .Returns(true);

                yield return new TestCaseData(
                    A.AAAAAAAAAAAAA)

                    .Returns(true);

                yield return new TestCaseData(
                    A.AaAaAaAaAaAaAaAaAaAaAaAaAaAaAaAaAaAaAaAaAaAaAaAaA)

                    .Returns(true);

                yield return new TestCaseData(
                    A.Afajfchdsfjksakk)

                    .Returns(true);

                yield return new TestCaseData(
                    A.ashfdhasfdhasfdhgsafdhgasfdhfashdfhgsafdgas236824e87326ehqshhjzjhxjjxzjhxgjhz)

                    .Returns(false);

                yield return new TestCaseData(
                    A.B)

                    .Returns(false);

                yield return new TestCaseData(
                    A.Bgg)

                    .Returns(false);

                yield return new TestCaseData(
                    A.BggdsdfdsffsJKKLKLDsskksd)

                    .Returns(false);

                yield return new TestCaseData(
                    A.fajfchdsfjksakkA)

                    .Returns(true);

                yield return new TestCaseData(
                    A.fajfchdsfjksakkAfajfchdsfjksakk)

                    .Returns(true);

                yield return new TestCaseData(
                    A.hdghsjdhaksjdhakjshdkjashdjkhskjdhaskjdhskjshdjkashdjkashdjkhasjdhaj)

                    .Returns(false);

                yield return new TestCaseData(
                    A.hjhjhjhjhjhjhjhjhjhjhjhjhjjhjAAAAAAAAAAAAAAAAAAAAajhjhjhjhjhjhjhAAAAAAAAAAAAAA)

                    .Returns(true);

                yield return new TestCaseData(
                    A.hsdghAdskhdjAAdhsjhdA)

                    .Returns(true);

                yield return new TestCaseData(
                    A.tttttttttAAAAAtdbndjsgdhAAadjgsjdgAAAdjhsgdhsgdAAAAjsdjsjAAA)

                    .Returns(true);

                yield return new TestCaseData(
                    A.weyiruyweiiryweiuyrieuwyriuewyriuweyriuweyiuewyruieyriuweeyuryewwiyeiur)

                    .Returns(false);

                yield return new TestCaseData(
                    A.___EMPTY___)

                    .Returns(false);

                #endregion
                #region <|  AA |>

                yield return new TestCaseData(
                    AA.________________________________________A)

                    .Returns(false);

                yield return new TestCaseData(
                    AA.________________________________________AA)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.________________________________________AA_AA___AA)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.________________________________________AAA)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.________________________________________AAAAA__AA_AAA_____AAAA_A_A)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.________________________________________AAAAAAAA)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.__________________________________A______)

                    .Returns(false);

                yield return new TestCaseData(
                    AA.__________________________________AA______)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.__________________________________AA_AA___AA______)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.__________________________________AAA______)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.__________________________________AAAAA__AA_AAA_____AAAA_A_A______)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.__________________________________AAAAAAAA______)

                    .Returns(true);

                yield return new TestCaseData(
                    AA._________________________A_______________)

                    .Returns(false);

                yield return new TestCaseData(
                    AA._________________________AA_______________)

                    .Returns(true);

                yield return new TestCaseData(
                    AA._________________________AA_AA___AA_______________)

                    .Returns(true);

                yield return new TestCaseData(
                    AA._________________________AAA_______________)

                    .Returns(true);

                yield return new TestCaseData(
                    AA._________________________AAAAA__AA_AAA_____AAAA_A_A_______________)

                    .Returns(true);

                yield return new TestCaseData(
                    AA._________________________AAAAAAAA_______________)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.____________________A____________________)

                    .Returns(false);

                yield return new TestCaseData(
                    AA.____________________AA____________________)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.____________________AA_AA___AA____________________)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.____________________AAA____________________)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.____________________AAAAA__AA_AAA_____AAAA_A_A____________________)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.____________________AAAAAAAA____________________)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.____________A____________________________)

                    .Returns(false);

                yield return new TestCaseData(
                    AA.____________AA____________________________)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.____________AA_AA___AA____________________________)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.____________AAA____________________________)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.____________AAAAA__AA_AAA_____AAAA_A_A____________________________)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.____________AAAAAAAA____________________________)

                    .Returns(true);

                yield return new TestCaseData(
                    AA._______A)

                    .Returns(false);

                yield return new TestCaseData(
                    AA._______AA)

                    .Returns(true);

                yield return new TestCaseData(
                    AA._______AAA)

                    .Returns(true);

                yield return new TestCaseData(
                    AA._______AAAAA__AA_AAA_____AAAA_A_A)

                    .Returns(true);

                yield return new TestCaseData(
                    AA._______AAAAAAAA)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.___A____)

                    .Returns(false);

                yield return new TestCaseData(
                    AA.___AA____)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.___AAA____)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.___AAAAA__AA_AAA_____AAAA_A_A____)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.___AAAAAAAA____)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.___EMPTY___)

                    .Returns(false);

                yield return new TestCaseData(
                    AA.___PATTERN__)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.__AAAAAAA)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.__AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.A_______)

                    .Returns(false);

                yield return new TestCaseData(
                    AA.A________________________________________)

                    .Returns(false);

                yield return new TestCaseData(
                    AA.AA_______)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.AA________________________________________)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.AA_AA___AA________________________________________)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.AAA_______)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.AAA________________________________________)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.AAA__AAAA)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.AAAAA__AA_AAA_____AAAA_A_A_______)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.AAAAA__AA_AAA_____AAAA_A_A________________________________________)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.AAAAAAA__)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.AAAAAAAA_______)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.AAAAAAAA________________________________________)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.aaaaaaaAA)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.aaaAAaaaa)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.AAaaaaaaa)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.AAAAAAAAAAAA__AAAAAAAAAAAAAAAAAAAAAAAAAAAA)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.AAAAAAAAAAAAAAAAAAAA__AAAAAAAAAAAAAAAAAAAA)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.AAAAAAAAAAAAAAAAAAAAAAAAA__AAAAAAAAAAAAAAA)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA__AAAAAA)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA__)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaAA)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaAAaaaaaa)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.aaaaaaaaaaaaaaaaaaaaaaaaaAAaaaaaaaaaaaaaaa)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.aaaaaaaaaaaaaaaaaaaaAAaaaaaaaaaaaaaaaaaaaa)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.aaaaaaaaaaaaAAaaaaaaaaaaaaaaaaaaaaaaaaaaaa)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.AAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.AAAAAAAAghytuuuutt11mmmmdDDDJJJJ00yfttppp5t)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.AAAAAAAAyyygt)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.AAAAAjoAAtAAAttppp5tAAAAtAtAghytuuuutt11mmmmdDDDJJJJ00yfttppp5t)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.AAAAAjoAAtAAAttppp5tAAAAtAtAyyygt)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.AAAghytuuuutt11mmmmdDDDJJJJ00yfttppp5t)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.AAAyyygt)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.AAghytuuuutt11mmmmdDDDJJJJ00yfttppp5t)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.AAtAAqmmAAghytuuuutt11mmmmdDDDJJJJ00yfttppp5t)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.AAyyygt)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.Aghytuuuutt11mmmmdDDDJJJJ00yfttppp5t)

                    .Returns(false);

                yield return new TestCaseData(
                    AA.Ayyygt)

                    .Returns(false);

                yield return new TestCaseData(
                    AA.DDDJJJJ00yfAAAAAAAAghytuuuutt11mmmmdttppp5t)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.DDDJJJJ00yfAAAAAjoAAtAAAttppp5tAAAAtAtAghytuuuutt11mmmmdttppp5t)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.DDDJJJJ00yfAAAghytuuuutt11mmmmdttppp5t)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.DDDJJJJ00yfAAghytuuuutt11mmmmdttppp5t)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.DDDJJJJ00yfAAtAAqmmAAghytuuuutt11mmmmdttppp5t)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.DDDJJJJ00yfAghytuuuutt11mmmmdttppp5t)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.ghytuuuutt11mmmmdDDDJJJJ00yfttppp5tA)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.ghytuuuutt11mmmmdDDDJJJJ00yfttppp5tAA)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.ghytuuuutt11mmmmdDDDJJJJ00yfttppp5tAAA)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.ghytuuuutt11mmmmdDDDJJJJ00yfttppp5tAAAAAAAA)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.ghytuuuutt11mmmmdDDDJJJJ00yfttppp5tAAAAAjoAAtAAAttppp5tAAAAtAtA)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.ghytuuuutt11mmmmdDDDJJJJ00yfttppp5tAAtAAqmmAA)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.ghytuuuutt11mmmmdjoAAAAAAAADDDJJJJ00yfqmm)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.ghytuuuutt11mmmmdjoAAAAAjoAAtAAAttppp5tAAAAtAtADDDJJJJ00yfqmm)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.ghytuuuutt11mmmmdjoAAADDDJJJJ00yfqmm)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.ghytuuuutt11mmmmdjoAADDDJJJJ00yfqmm)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.ghytuuuutt11mmmmdjoAAtAAqmmAADDDJJJJ00yfqmm)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.ghytuuuutt11mmmmdjoADDDJJJJ00yfqmm)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.ghytuuuutt11mmmmdrrrrhrhrhrqmmAAAAAAAAyyyg)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.ghytuuuutt11mmmmdrrrrhrhrhrqmmAAAAAjoAAtAAAttppp5tAAAAtAtAyyyg)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.ghytuuuutt11mmmmdrrrrhrhrhrqmmAAAyyyg)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.ghytuuuutt11mmmmdrrrrhrhrhrqmmAAtAAqmmAAyyyg)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.ghytuuuutt11mmmmdrrrrhrhrhrqmmAAyyyg)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.ghytuuuutt11mmmmdrrrrhrhrhrqmmAyyyg)

                    .Returns(false);

                yield return new TestCaseData(
                    AA.qmmAAAAAAAAttppp5)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.DDDJJJJ00yfAAAghytuuuutt11mmmmdttppp5t)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.qmmAAAAAjoAAtAAAttppp5tAAAAtAtAttppp5)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.qmmAAAttppp5)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.qmmAAttppp5)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.qmmAttppp5)

                    .Returns(false);

                yield return new TestCaseData(
                    AA.sdkfjkdsckjsdjcnkj)

                    .Returns(false);

                yield return new TestCaseData(
                    AA.ttyyyysdkskksksjoAAAAAAAAttyyyysdkskksksjo)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.ttyyyysdkskksksjoAAAAAjoAAtAAAttppp5tAAAAtAtAttyyyysdkskksksjo)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.ttyyyysdkskksksjoAAAttyyyysdkskksksjo)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.ttyyyysdkskksksjoAAtAAqmmAAttyyyysdkskksksjo)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.ttyyyysdkskksksjoAAttyyyysdkskksksjo)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.ttyyyysdkskksksjoAttyyyysdkskksksjo)

                    .Returns(false);

                yield return new TestCaseData(
                    AA.vbhfsadkjfjxhvlkxjnvkhcjvbxjzbchvbjdahaidiajdnvkjdnvlkadnvjcnkvjjncdcj)

                    .Returns(false);

                yield return new TestCaseData(
                    AA.X)

                    .Returns(false);

                yield return new TestCaseData(
                    AA.yyygtA)

                    .Returns(false);

                yield return new TestCaseData(
                    AA.yyygtAA)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.yyygtAAA)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.yyygtAAAAAAAA)

                    .Returns(true);

                yield return new TestCaseData(
                    AA.yyygtAAAAAjoAAtAAAttppp5tAAAAtAtA)

                    .Returns(true);

                #endregion
            }
        }

        private static class A
        {
            public static readonly Case<char>
                ___EMPTY___ = 
                    new Case(""),
                ___PATTERN___ =
                    new Case("A"),
                aaaaaaA =
                    new Case("aaaaaaA"),
                hsdghAdskhdjAAdhsjhdA =
                    new Case("hsdghAdskhdjAAdhsjhdA"),
                Aaaaaaaaaaaa =
                    new Case("Aaaaaaaaaaaa"),
                AAAAAAAAAAAAA =
                    new Case("AAAAAAAAAAAAA"),
                fajfchdsfjksakkA =
                    new Case("fajfchdsfjksakkA"),
                fajfchdsfjksakkAfajfchdsfjksakk =
                    new Case("fajfchdsfjksakkAfajfchdsfjksakk"),
                Afajfchdsfjksakk =
                    new Case("Afajfchdsfjksakk"),
                AaAaAaAaAaAaAaAaAaAaAaAaAaAaAaAaAaAaAaAaAaAaAaAaA =
                    new Case("AaAaAaAaAaAaAaAaAaAaAaAaAaAaAaAaAaAaAaAaAaAaAaAaA"),
                _________A________________A__________A____________A______A__________AA =
                    new Case("_________A________________A__________A____________A______A__________AA"),
                AAAA_________A___AAAA______A__________A________AAAAA____A______A__________AA =
                    new Case("AAAA_________A___AAAA______A__________A________AAAAA____A______A__________AA"),
                A_A___AAAA____AAA____AAA___AAAAAAAAAAAAAAAAAAAAAAAAAAAAA =
                    new Case("A_A___AAAA____AAA____AAA___AAAAAAAAAAAAAAAAAAAAAAAAAAAAA"),
                hjhjhjhjhjhjhjhjhjhjhjhjhjjhjAAAAAAAAAAAAAAAAAAAAajhjhjhjhjhjhjhAAAAAAAAAAAAAA =
                    new Case("A_A___AAAA____AAA____AAA___AAAAAAAAAAAAAAAAAAAAAAAAAAAAA"),
                tttttttttAAAAAtdbndjsgdhAAadjgsjdgAAAdjhsgdhsgdAAAAjsdjsjAAA =
                    new Case("tttttttttAAAAAtdbndjsgdhAAadjgsjdgAAAdjhsgdhsgdAAAAjsdjsjAAA"),
                __________________________________A____________________________ =
                    new Case("tttttttttAAAAAtdbndjsgdhAAadjgsjdgAAAdjhsgdhsgdAAAAjsdjsjAAA"),
                A______________________________________________________________ =
                    new Case("A______________________________________________________________"),
                ______________________________________________________________A =
                    new Case("A______________________________________________________________"),
                B =
                    new Case("B"),
                Bgg =
                    new Case("Bgg"),
                BggdsdfdsffsJKKLKLDsskksd =
                    new Case("BggdsdfdsffsJKKLKLDsskksd"),
                hdghsjdhaksjdhakjshdkjashdjkhskjdhaskjdhskjshdjkashdjkashdjkhasjdhaj =
                    new Case("hdghsjdhaksjdhakjshdkjashdjkhskjdhaskjdhskjshdjkashdjkashdjkhasjdhaj"),
                ashfdhasfdhasfdhgsafdhgasfdhfashdfhgsafdgas236824e87326ehqshhjzjhxjjxzjhxgjhz =
                    new Case("ashfdhasfdhasfdhgsafdhgasfdhfashdfhgsafdgas236824e87326ehqshhjzjhxjjxzjhxgjhz"),
                ___________________________________________________________________________________ =
                    new Case("___________________________________________________________________________________"),
                weyiruyweiiryweiuyrieuwyriuewyriuweyriuweyiuewyruieyriuweeyuryewwiyeiur =
                    new Case("weyiruyweiiryweiuyrieuwyriuewyriuweyriuweyiuewyruieyriuweeyuryewwiyeiur");

            private class Case : Case<char>
            {
                public Case(string source)
                    : base("A", source) { }
            }
        }

        private static class AA
        {
            public static readonly Case<char>
                ___EMPTY___ =
                    new Case(""),
                ___PATTERN__ =
                    new Case("AA"),
                AA_______ =
                    new Case("AA_______"),
                ___AA____ =
                    new Case("___AA____"),
                _______AA =
                    new Case("_______AA"),
                AA________________________________________ =
                    new Case("AA________________________________________"),
                ____________AA____________________________ =
                    new Case("____________AA____________________________"),
                ____________________AA____________________ =
                    new Case("____________________AA____________________"),
                _________________________AA_______________ =
                    new Case("_________________________AA_______________"),
                __________________________________AA______ =
                    new Case("__________________________________AA______"),
                ________________________________________AA =
                    new Case("________________________________________AA"),
                AAA_______ =
                    new Case("AAA_______"),
                ___AAA____ =
                    new Case("___AAA____"),
                _______AAA =
                    new Case("_______AAA"),
                AAA________________________________________ =
                    new Case("AAA________________________________________"),
                ____________AAA____________________________ =
                    new Case("____________AAA____________________________"),
                ____________________AAA____________________ =
                    new Case("____________________AAA____________________"),
                _________________________AAA_______________ =
                    new Case("_________________________AAA_______________"),
                __________________________________AAA______ =
                    new Case("__________________________________AAA______"),
                ________________________________________AAA =
                    new Case("________________________________________AAA"),
                AAAAAAAA_______ =
                    new Case("AAAAAAAA_______"),
                ___AAAAAAAA____ =
                    new Case("___AAAAAAAA____"),
                _______AAAAAAAA =
                    new Case("_______AAAAAAAA"),
                AAAAAAAA________________________________________ =
                    new Case("AAAAAAAA________________________________________"),
                ____________AAAAAAAA____________________________ =
                    new Case("____________AAAAAAAA____________________________"),
                ____________________AAAAAAAA____________________ =
                    new Case("____________________AAAAAAAA____________________"),
                _________________________AAAAAAAA_______________ =
                    new Case("_________________________AAAAAAAA_______________"),
                __________________________________AAAAAAAA______ =
                    new Case("__________________________________AAAAAAAA______"),
                ________________________________________AAAAAAAA =
                    new Case("________________________________________AAAAAAAA"),
                AA_AA___AA________________________________________ =
                    new Case("AA_AA___AA________________________________________"),
                ____________AA_AA___AA____________________________ =
                    new Case("____________AA_AA___AA____________________________"),
                ____________________AA_AA___AA____________________ =
                    new Case("____________________AA_AA___AA____________________"),
                _________________________AA_AA___AA_______________ =
                    new Case("_________________________AA_AA___AA_______________"),
                __________________________________AA_AA___AA______ =
                    new Case("__________________________________AA_AA___AA______"),
                ________________________________________AA_AA___AA =
                    new Case("________________________________________AA_AA___AA"),
                A_______ =
                    new Case("A_______"),
                ___A____ =
                    new Case("___A____"),
                _______A =
                    new Case("_______A"),
                A________________________________________ =
                    new Case("A________________________________________"),
                ____________A____________________________ =
                    new Case("____________A____________________________"),
                ____________________A____________________ =
                    new Case("____________________A____________________"),
                _________________________A_______________ =
                    new Case("_________________________A_______________"),
                __________________________________A______ =
                    new Case("__________________________________A______"),
                ________________________________________A =
                    new Case("________________________________________A"),
                AAAAA__AA_AAA_____AAAA_A_A_______ =
                    new Case("AAAAA__AA_AAA_____AAAA_A_A_______"),
                ___AAAAA__AA_AAA_____AAAA_A_A____ =
                    new Case("___AAAAA__AA_AAA_____AAAA_A_A____"),
                _______AAAAA__AA_AAA_____AAAA_A_A =
                    new Case("_______AAAAA__AA_AAA_____AAAA_A_A"),
                AAAAA__AA_AAA_____AAAA_A_A________________________________________ =
                    new Case("AAAAA__AA_AAA_____AAAA_A_A________________________________________"),
                ____________AAAAA__AA_AAA_____AAAA_A_A____________________________ =
                    new Case("____________AAAAA__AA_AAA_____AAAA_A_A____________________________"),
                ____________________AAAAA__AA_AAA_____AAAA_A_A____________________ =
                    new Case("____________________AAAAA__AA_AAA_____AAAA_A_A____________________"),
                _________________________AAAAA__AA_AAA_____AAAA_A_A_______________ =
                    new Case("_________________________AAAAA__AA_AAA_____AAAA_A_A_______________"),
                __________________________________AAAAA__AA_AAA_____AAAA_A_A______ =
                    new Case("__________________________________AAAAA__AA_AAA_____AAAA_A_A______"),
                ________________________________________AAAAA__AA_AAA_____AAAA_A_A =
                    new Case("________________________________________AAAAA__AA_AAA_____AAAA_A_A"),
                __AAAAAAA =
                    new Case("__AAAAAAA"),
                AAA__AAAA =
                    new Case("AAA__AAAA"),
                AAAAAAA__ =
                    new Case("AAAAAAA__"),
                __AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA =
                    new Case("__AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"),
                AAAAAAAAAAAA__AAAAAAAAAAAAAAAAAAAAAAAAAAAA =
                    new Case("AAAAAAAAAAAA__AAAAAAAAAAAAAAAAAAAAAAAAAAAA"),
                AAAAAAAAAAAAAAAAAAAA__AAAAAAAAAAAAAAAAAAAA =
                    new Case("AAAAAAAAAAAAAAAAAAAA__AAAAAAAAAAAAAAAAAAAA"),
                AAAAAAAAAAAAAAAAAAAAAAAAA__AAAAAAAAAAAAAAA =
                    new Case("AAAAAAAAAAAAAAAAAAAAAAAAA__AAAAAAAAAAAAAAA"),
                AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA__AAAAAA =
                    new Case("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA__AAAAAA"),
                AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA__ =
                    new Case("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA__"),
                AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA =
                    new Case("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"),
                X =
                    new Case("X"),
                vbhfsadkjfjxhvlkxjnvkhcjvbxjzbchvbjdahaidiajdnvkjdnvlkadnvjcnkvjjncdcj =
                    new Case("vbhfsadkjfjxhvlkxjnvkhcjvbxjzbchvbjdahaidiajdnvkjdnvlkadnvjcnkvjjncdcj"),
                sdkfjkdsckjsdjcnkj =
                    new Case("sdkfjkdsckjsdjcnkj"),
                AAaaaaaaa =
                    new Case("AAaaaaaaa"),
                aaaAAaaaa =
                    new Case("aaaAAaaaa"),
                aaaaaaaAA =
                    new Case("aaaaaaaAA"),
                AAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa =
                    new Case("AAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"),
                aaaaaaaaaaaaAAaaaaaaaaaaaaaaaaaaaaaaaaaaaa =
                    new Case("aaaaaaaaaaaaAAaaaaaaaaaaaaaaaaaaaaaaaaaaaa"),
                aaaaaaaaaaaaaaaaaaaaAAaaaaaaaaaaaaaaaaaaaa =
                    new Case("aaaaaaaaaaaaaaaaaaaaAAaaaaaaaaaaaaaaaaaaaa"),
                aaaaaaaaaaaaaaaaaaaaaaaaaAAaaaaaaaaaaaaaaa =
                    new Case("aaaaaaaaaaaaaaaaaaaaaaaaaAAaaaaaaaaaaaaaaa"),
                aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaAAaaaaaa =
                    new Case("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaAAaaaaaa"),
                aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaAA =
                    new Case("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaAA"),
                AAyyygt =
                    new Case("AAyyygt"),
                qmmAAttppp5 =
                    new Case("qmmAAttppp5"),
                yyygtAA =
                    new Case("yyygtAA"),
                AAghytuuuutt11mmmmdDDDJJJJ00yfttppp5t =
                    new Case("AAghytuuuutt11mmmmdDDDJJJJ00yfttppp5t"),
                DDDJJJJ00yfAAghytuuuutt11mmmmdttppp5t =
                    new Case("DDDJJJJ00yfAAghytuuuutt11mmmmdttppp5t"),
                ttyyyysdkskksksjoAAttyyyysdkskksksjo =
                    new Case("ttyyyysdkskksksjoAAttyyyysdkskksksjo"),
                ghytuuuutt11mmmmdjoAADDDJJJJ00yfqmm =
                    new Case("ghytuuuutt11mmmmdjoAADDDJJJJ00yfqmm"),
                ghytuuuutt11mmmmdrrrrhrhrhrqmmAAyyyg =
                    new Case("ghytuuuutt11mmmmdrrrrhrhrhrqmmAAyyyg"),
                ghytuuuutt11mmmmdDDDJJJJ00yfttppp5tAA =
                    new Case("ghytuuuutt11mmmmdDDDJJJJ00yfttppp5tAA"),
                AAAyyygt =
                    new Case("AAAyyygt"),
                qmmAAAttppp5 =
                    new Case("qmmAAAttppp5"),
                yyygtAAA =
                    new Case("yyygtAAA"),
                AAAghytuuuutt11mmmmdDDDJJJJ00yfttppp5t =
                    new Case("AAAghytuuuutt11mmmmdDDDJJJJ00yfttppp5t"),
                DDDJJJJ00yfAAAghytuuuutt11mmmmdttppp5t =
                    new Case("DDDJJJJ00yfAAAghytuuuutt11mmmmdttppp5t"),
                ttyyyysdkskksksjoAAAttyyyysdkskksksjo =
                    new Case("ttyyyysdkskksksjoAAAttyyyysdkskksksjo"),
                ghytuuuutt11mmmmdjoAAADDDJJJJ00yfqmm =
                    new Case("ghytuuuutt11mmmmdjoAAADDDJJJJ00yfqmm"),
                ghytuuuutt11mmmmdrrrrhrhrhrqmmAAAyyyg =
                    new Case("ghytuuuutt11mmmmdrrrrhrhrhrqmmAAAyyyg"),
                ghytuuuutt11mmmmdDDDJJJJ00yfttppp5tAAA =
                    new Case("ghytuuuutt11mmmmdDDDJJJJ00yfttppp5tAAA"),
                AAAAAAAAyyygt =
                    new Case("AAAAAAAAyyygt"),
                qmmAAAAAAAAttppp5 =
                    new Case("qmmAAAAAAAAttppp5"),
                yyygtAAAAAAAA =
                    new Case("yyygtAAAAAAAA"),
                AAAAAAAAghytuuuutt11mmmmdDDDJJJJ00yfttppp5t =
                    new Case("AAAAAAAAghytuuuutt11mmmmdDDDJJJJ00yfttppp5t"),
                DDDJJJJ00yfAAAAAAAAghytuuuutt11mmmmdttppp5t =
                    new Case("DDDJJJJ00yfAAAAAAAAghytuuuutt11mmmmdttppp5t"),
                ttyyyysdkskksksjoAAAAAAAAttyyyysdkskksksjo =
                    new Case("ttyyyysdkskksksjoAAAAAAAAttyyyysdkskksksjo"),
                ghytuuuutt11mmmmdjoAAAAAAAADDDJJJJ00yfqmm =
                    new Case("ghytuuuutt11mmmmdjoAAAAAAAADDDJJJJ00yfqmm"),
                ghytuuuutt11mmmmdrrrrhrhrhrqmmAAAAAAAAyyyg =
                    new Case("ghytuuuutt11mmmmdrrrrhrhrhrqmmAAAAAAAAyyyg"),
                ghytuuuutt11mmmmdDDDJJJJ00yfttppp5tAAAAAAAA =
                    new Case("ghytuuuutt11mmmmdDDDJJJJ00yfttppp5tAAAAAAAA"),
                AAtAAqmmAAghytuuuutt11mmmmdDDDJJJJ00yfttppp5t =
                    new Case("AAtAAqmmAAghytuuuutt11mmmmdDDDJJJJ00yfttppp5t"),
                DDDJJJJ00yfAAtAAqmmAAghytuuuutt11mmmmdttppp5t =
                    new Case("DDDJJJJ00yfAAtAAqmmAAghytuuuutt11mmmmdttppp5t"),
                ttyyyysdkskksksjoAAtAAqmmAAttyyyysdkskksksjo =
                    new Case("ttyyyysdkskksksjoAAtAAqmmAAttyyyysdkskksksjo"),
                ghytuuuutt11mmmmdjoAAtAAqmmAADDDJJJJ00yfqmm =
                    new Case("ghytuuuutt11mmmmdjoAAtAAqmmAADDDJJJJ00yfqmm"),
                ghytuuuutt11mmmmdrrrrhrhrhrqmmAAtAAqmmAAyyyg =
                    new Case("ghytuuuutt11mmmmdrrrrhrhrhrqmmAAtAAqmmAAyyyg"),
                ghytuuuutt11mmmmdDDDJJJJ00yfttppp5tAAtAAqmmAA =
                    new Case("ghytuuuutt11mmmmdDDDJJJJ00yfttppp5tAAtAAqmmAA"),
                Ayyygt =
                    new Case("Ayyygt"),
                qmmAttppp5 =
                    new Case("qmmAttppp5"),
                yyygtA =
                    new Case("yyygtA"),
                Aghytuuuutt11mmmmdDDDJJJJ00yfttppp5t =
                    new Case("Aghytuuuutt11mmmmdDDDJJJJ00yfttppp5t"),
                DDDJJJJ00yfAghytuuuutt11mmmmdttppp5t =
                    new Case("DDDJJJJ00yfAghytuuuutt11mmmmdttppp5t"),
                ttyyyysdkskksksjoAttyyyysdkskksksjo =
                    new Case("ttyyyysdkskksksjoAttyyyysdkskksksjo"),
                ghytuuuutt11mmmmdjoADDDJJJJ00yfqmm =
                    new Case("ghytuuuutt11mmmmdjoADDDJJJJ00yfqmm"),
                ghytuuuutt11mmmmdrrrrhrhrhrqmmAyyyg =
                    new Case("ghytuuuutt11mmmmdrrrrhrhrhrqmmAyyyg"),
                ghytuuuutt11mmmmdDDDJJJJ00yfttppp5tA =
                    new Case("ghytuuuutt11mmmmdDDDJJJJ00yfttppp5tA"),
                AAAAAjoAAtAAAttppp5tAAAAtAtAyyygt =
                    new Case("AAAAAjoAAtAAAttppp5tAAAAtAtAyyygt"),
                qmmAAAAAjoAAtAAAttppp5tAAAAtAtAttppp5 =
                    new Case("qmmAAAAAjoAAtAAAttppp5tAAAAtAtAttppp5"),
                yyygtAAAAAjoAAtAAAttppp5tAAAAtAtA =
                    new Case("yyygtAAAAAjoAAtAAAttppp5tAAAAtAtA"),
                AAAAAjoAAtAAAttppp5tAAAAtAtAghytuuuutt11mmmmdDDDJJJJ00yfttppp5t =
                    new Case("AAAAAjoAAtAAAttppp5tAAAAtAtAghytuuuutt11mmmmdDDDJJJJ00yfttppp5t"),
                DDDJJJJ00yfAAAAAjoAAtAAAttppp5tAAAAtAtAghytuuuutt11mmmmdttppp5t =
                    new Case("DDDJJJJ00yfAAAAAjoAAtAAAttppp5tAAAAtAtAghytuuuutt11mmmmdttppp5t"),
                ttyyyysdkskksksjoAAAAAjoAAtAAAttppp5tAAAAtAtAttyyyysdkskksksjo =
                    new Case("ttyyyysdkskksksjoAAAAAjoAAtAAAttppp5tAAAAtAtAttyyyysdkskksksjo"),
                ghytuuuutt11mmmmdjoAAAAAjoAAtAAAttppp5tAAAAtAtADDDJJJJ00yfqmm =
                    new Case("ghytuuuutt11mmmmdjoAAAAAjoAAtAAAttppp5tAAAAtAtADDDJJJJ00yfqmm"),
                ghytuuuutt11mmmmdrrrrhrhrhrqmmAAAAAjoAAtAAAttppp5tAAAAtAtAyyyg =
                    new Case("ghytuuuutt11mmmmdrrrrhrhrhrqmmAAAAAjoAAtAAAttppp5tAAAAtAtAyyyg"),
                ghytuuuutt11mmmmdDDDJJJJ00yfttppp5tAAAAAjoAAtAAAttppp5tAAAAtAtA =
                    new Case("ghytuuuutt11mmmmdDDDJJJJ00yfttppp5tAAAAAjoAAtAAAttppp5tAAAAtAtA");

            private class Case : Case<char>
            {
                public Case(string source)
                    : base("AA", source) { }
            }
        }
    }
}
