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

                    .Returns(true);

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

                    .Returns(false);

                yield return new TestCaseData(
                    A.fajfchdsfjksakkAfajfchdsfjksakk)

                    .Returns(false);

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
    }
}
