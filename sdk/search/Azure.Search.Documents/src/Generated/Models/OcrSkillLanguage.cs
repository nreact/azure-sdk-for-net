// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> The language codes supported for input by OcrSkill. </summary>
    public readonly partial struct OcrSkillLanguage : IEquatable<OcrSkillLanguage>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OcrSkillLanguage"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OcrSkillLanguage(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AfValue = "af";
        private const string SqValue = "sq";
        private const string AnpValue = "anp";
        private const string ArValue = "ar";
        private const string AstValue = "ast";
        private const string AwaValue = "awa";
        private const string AzValue = "az";
        private const string BfyValue = "bfy";
        private const string EuValue = "eu";
        private const string BeValue = "be";
        private const string BeCyrlValue = "be-cyrl";
        private const string BeLatnValue = "be-latn";
        private const string BhoValue = "bho";
        private const string BiValue = "bi";
        private const string BrxValue = "brx";
        private const string BsValue = "bs";
        private const string BraValue = "bra";
        private const string BrValue = "br";
        private const string BgValue = "bg";
        private const string BnsValue = "bns";
        private const string BuaValue = "bua";
        private const string CaValue = "ca";
        private const string CebValue = "ceb";
        private const string RabValue = "rab";
        private const string ChValue = "ch";
        private const string HneValue = "hne";
        private const string ZhHansValue = "zh-Hans";
        private const string ZhHantValue = "zh-Hant";
        private const string KwValue = "kw";
        private const string CoValue = "co";
        private const string CrhValue = "crh";
        private const string HrValue = "hr";
        private const string CsValue = "cs";
        private const string DaValue = "da";
        private const string PrsValue = "prs";
        private const string DhiValue = "dhi";
        private const string DoiValue = "doi";
        private const string NlValue = "nl";
        private const string EnValue = "en";
        private const string MyvValue = "myv";
        private const string EtValue = "et";
        private const string FoValue = "fo";
        private const string FjValue = "fj";
        private const string FilValue = "fil";
        private const string FiValue = "fi";
        private const string FrValue = "fr";
        private const string FurValue = "fur";
        private const string GagValue = "gag";
        private const string GlValue = "gl";
        private const string DeValue = "de";
        private const string GilValue = "gil";
        private const string GonValue = "gon";
        private const string ElValue = "el";
        private const string KlValue = "kl";
        private const string GvrValue = "gvr";
        private const string HtValue = "ht";
        private const string HlbValue = "hlb";
        private const string HniValue = "hni";
        private const string BgcValue = "bgc";
        private const string HawValue = "haw";
        private const string HiValue = "hi";
        private const string MwwValue = "mww";
        private const string HocValue = "hoc";
        private const string HuValue = "hu";
        private const string IsValue = "is";
        private const string SmnValue = "smn";
        private const string IdValue = "id";
        private const string IaValue = "ia";
        private const string IuValue = "iu";
        private const string GaValue = "ga";
        private const string ItValue = "it";
        private const string JaValue = "ja";
        private const string JnsValue = "Jns";
        private const string JvValue = "jv";
        private const string KeaValue = "kea";
        private const string KacValue = "kac";
        private const string XnrValue = "xnr";
        private const string KrcValue = "krc";
        private const string KaaCyrlValue = "kaa-cyrl";
        private const string KaaValue = "kaa";
        private const string CsbValue = "csb";
        private const string KkCyrlValue = "kk-cyrl";
        private const string KkLatnValue = "kk-latn";
        private const string KlrValue = "klr";
        private const string KhaValue = "kha";
        private const string QucValue = "quc";
        private const string KoValue = "ko";
        private const string KfqValue = "kfq";
        private const string KpyValue = "kpy";
        private const string KosValue = "kos";
        private const string KumValue = "kum";
        private const string KuArabValue = "ku-arab";
        private const string KuLatnValue = "ku-latn";
        private const string KruValue = "kru";
        private const string KyValue = "ky";
        private const string LktValue = "lkt";
        private const string LaValue = "la";
        private const string LtValue = "lt";
        private const string DsbValue = "dsb";
        private const string SmjValue = "smj";
        private const string LbValue = "lb";
        private const string BfzValue = "bfz";
        private const string MsValue = "ms";
        private const string MtValue = "mt";
        private const string KmjValue = "kmj";
        private const string GvValue = "gv";
        private const string MiValue = "mi";
        private const string MrValue = "mr";
        private const string MnValue = "mn";
        private const string CnrCyrlValue = "cnr-cyrl";
        private const string CnrLatnValue = "cnr-latn";
        private const string NapValue = "nap";
        private const string NeValue = "ne";
        private const string NiuValue = "niu";
        private const string NogValue = "nog";
        private const string SmeValue = "sme";
        private const string NbValue = "nb";
        private const string NoValue = "no";
        private const string OcValue = "oc";
        private const string OsValue = "os";
        private const string PsValue = "ps";
        private const string FaValue = "fa";
        private const string PlValue = "pl";
        private const string PtValue = "pt";
        private const string PaValue = "pa";
        private const string KshValue = "ksh";
        private const string RoValue = "ro";
        private const string RmValue = "rm";
        private const string RuValue = "ru";
        private const string SckValue = "sck";
        private const string SmValue = "sm";
        private const string SaValue = "sa";
        private const string SatValue = "sat";
        private const string ScoValue = "sco";
        private const string GdValue = "gd";
        private const string SrValue = "sr";
        private const string SrCyrlValue = "sr-Cyrl";
        private const string SrLatnValue = "sr-Latn";
        private const string XsrValue = "xsr";
        private const string SrxValue = "srx";
        private const string SmsValue = "sms";
        private const string SkValue = "sk";
        private const string SlValue = "sl";
        private const string SoValue = "so";
        private const string SmaValue = "sma";
        private const string EsValue = "es";
        private const string SwValue = "sw";
        private const string SvValue = "sv";
        private const string TgValue = "tg";
        private const string TtValue = "tt";
        private const string TetValue = "tet";
        private const string ThfValue = "thf";
        private const string ToValue = "to";
        private const string TrValue = "tr";
        private const string TkValue = "tk";
        private const string TyvValue = "tyv";
        private const string HsbValue = "hsb";
        private const string UrValue = "ur";
        private const string UgValue = "ug";
        private const string UzArabValue = "uz-arab";
        private const string UzCyrlValue = "uz-cyrl";
        private const string UzValue = "uz";
        private const string VoValue = "vo";
        private const string WaeValue = "wae";
        private const string CyValue = "cy";
        private const string FyValue = "fy";
        private const string YuaValue = "yua";
        private const string ZaValue = "za";
        private const string ZuValue = "zu";
        private const string UnkValue = "unk";

        /// <summary> Afrikaans. </summary>
        public static OcrSkillLanguage Af { get; } = new OcrSkillLanguage(AfValue);
        /// <summary> Albanian. </summary>
        public static OcrSkillLanguage Sq { get; } = new OcrSkillLanguage(SqValue);
        /// <summary> Angika (Devanagiri). </summary>
        public static OcrSkillLanguage Anp { get; } = new OcrSkillLanguage(AnpValue);
        /// <summary> Arabic. </summary>
        public static OcrSkillLanguage Ar { get; } = new OcrSkillLanguage(ArValue);
        /// <summary> Asturian. </summary>
        public static OcrSkillLanguage Ast { get; } = new OcrSkillLanguage(AstValue);
        /// <summary> Awadhi-Hindi (Devanagiri). </summary>
        public static OcrSkillLanguage Awa { get; } = new OcrSkillLanguage(AwaValue);
        /// <summary> Azerbaijani (Latin). </summary>
        public static OcrSkillLanguage Az { get; } = new OcrSkillLanguage(AzValue);
        /// <summary> Bagheli. </summary>
        public static OcrSkillLanguage Bfy { get; } = new OcrSkillLanguage(BfyValue);
        /// <summary> Basque. </summary>
        public static OcrSkillLanguage Eu { get; } = new OcrSkillLanguage(EuValue);
        /// <summary> Belarusian (Cyrillic and Latin). </summary>
        public static OcrSkillLanguage Be { get; } = new OcrSkillLanguage(BeValue);
        /// <summary> Belarusian (Cyrillic). </summary>
        public static OcrSkillLanguage BeCyrl { get; } = new OcrSkillLanguage(BeCyrlValue);
        /// <summary> Belarusian (Latin). </summary>
        public static OcrSkillLanguage BeLatn { get; } = new OcrSkillLanguage(BeLatnValue);
        /// <summary> Bhojpuri-Hindi (Devanagiri). </summary>
        public static OcrSkillLanguage Bho { get; } = new OcrSkillLanguage(BhoValue);
        /// <summary> Bislama. </summary>
        public static OcrSkillLanguage Bi { get; } = new OcrSkillLanguage(BiValue);
        /// <summary> Bodo (Devanagiri). </summary>
        public static OcrSkillLanguage Brx { get; } = new OcrSkillLanguage(BrxValue);
        /// <summary> Bosnian Latin. </summary>
        public static OcrSkillLanguage Bs { get; } = new OcrSkillLanguage(BsValue);
        /// <summary> Brajbha. </summary>
        public static OcrSkillLanguage Bra { get; } = new OcrSkillLanguage(BraValue);
        /// <summary> Breton. </summary>
        public static OcrSkillLanguage Br { get; } = new OcrSkillLanguage(BrValue);
        /// <summary> Bulgarian. </summary>
        public static OcrSkillLanguage Bg { get; } = new OcrSkillLanguage(BgValue);
        /// <summary> Bundeli. </summary>
        public static OcrSkillLanguage Bns { get; } = new OcrSkillLanguage(BnsValue);
        /// <summary> Buryat (Cyrillic). </summary>
        public static OcrSkillLanguage Bua { get; } = new OcrSkillLanguage(BuaValue);
        /// <summary> Catalan. </summary>
        public static OcrSkillLanguage Ca { get; } = new OcrSkillLanguage(CaValue);
        /// <summary> Cebuano. </summary>
        public static OcrSkillLanguage Ceb { get; } = new OcrSkillLanguage(CebValue);
        /// <summary> Chamling. </summary>
        public static OcrSkillLanguage Rab { get; } = new OcrSkillLanguage(RabValue);
        /// <summary> Chamorro. </summary>
        public static OcrSkillLanguage Ch { get; } = new OcrSkillLanguage(ChValue);
        /// <summary> Chhattisgarhi (Devanagiri). </summary>
        public static OcrSkillLanguage Hne { get; } = new OcrSkillLanguage(HneValue);
        /// <summary> Chinese Simplified. </summary>
        public static OcrSkillLanguage ZhHans { get; } = new OcrSkillLanguage(ZhHansValue);
        /// <summary> Chinese Traditional. </summary>
        public static OcrSkillLanguage ZhHant { get; } = new OcrSkillLanguage(ZhHantValue);
        /// <summary> Cornish. </summary>
        public static OcrSkillLanguage Kw { get; } = new OcrSkillLanguage(KwValue);
        /// <summary> Corsican. </summary>
        public static OcrSkillLanguage Co { get; } = new OcrSkillLanguage(CoValue);
        /// <summary> Crimean Tatar (Latin). </summary>
        public static OcrSkillLanguage Crh { get; } = new OcrSkillLanguage(CrhValue);
        /// <summary> Croatian. </summary>
        public static OcrSkillLanguage Hr { get; } = new OcrSkillLanguage(HrValue);
        /// <summary> Czech. </summary>
        public static OcrSkillLanguage Cs { get; } = new OcrSkillLanguage(CsValue);
        /// <summary> Danish. </summary>
        public static OcrSkillLanguage Da { get; } = new OcrSkillLanguage(DaValue);
        /// <summary> Dari. </summary>
        public static OcrSkillLanguage Prs { get; } = new OcrSkillLanguage(PrsValue);
        /// <summary> Dhimal (Devanagiri). </summary>
        public static OcrSkillLanguage Dhi { get; } = new OcrSkillLanguage(DhiValue);
        /// <summary> Dogri (Devanagiri). </summary>
        public static OcrSkillLanguage Doi { get; } = new OcrSkillLanguage(DoiValue);
        /// <summary> Dutch. </summary>
        public static OcrSkillLanguage Nl { get; } = new OcrSkillLanguage(NlValue);
        /// <summary> English. </summary>
        public static OcrSkillLanguage En { get; } = new OcrSkillLanguage(EnValue);
        /// <summary> Erzya (Cyrillic). </summary>
        public static OcrSkillLanguage Myv { get; } = new OcrSkillLanguage(MyvValue);
        /// <summary> Estonian. </summary>
        public static OcrSkillLanguage Et { get; } = new OcrSkillLanguage(EtValue);
        /// <summary> Faroese. </summary>
        public static OcrSkillLanguage Fo { get; } = new OcrSkillLanguage(FoValue);
        /// <summary> Fijian. </summary>
        public static OcrSkillLanguage Fj { get; } = new OcrSkillLanguage(FjValue);
        /// <summary> Filipino. </summary>
        public static OcrSkillLanguage Fil { get; } = new OcrSkillLanguage(FilValue);
        /// <summary> Finnish. </summary>
        public static OcrSkillLanguage Fi { get; } = new OcrSkillLanguage(FiValue);
        /// <summary> French. </summary>
        public static OcrSkillLanguage Fr { get; } = new OcrSkillLanguage(FrValue);
        /// <summary> Frulian. </summary>
        public static OcrSkillLanguage Fur { get; } = new OcrSkillLanguage(FurValue);
        /// <summary> Gagauz (Latin). </summary>
        public static OcrSkillLanguage Gag { get; } = new OcrSkillLanguage(GagValue);
        /// <summary> Galician. </summary>
        public static OcrSkillLanguage Gl { get; } = new OcrSkillLanguage(GlValue);
        /// <summary> German. </summary>
        public static OcrSkillLanguage De { get; } = new OcrSkillLanguage(DeValue);
        /// <summary> Gilbertese. </summary>
        public static OcrSkillLanguage Gil { get; } = new OcrSkillLanguage(GilValue);
        /// <summary> Gondi (Devanagiri). </summary>
        public static OcrSkillLanguage Gon { get; } = new OcrSkillLanguage(GonValue);
        /// <summary> Greek. </summary>
        public static OcrSkillLanguage El { get; } = new OcrSkillLanguage(ElValue);
        /// <summary> Greenlandic. </summary>
        public static OcrSkillLanguage Kl { get; } = new OcrSkillLanguage(KlValue);
        /// <summary> Gurung (Devanagiri). </summary>
        public static OcrSkillLanguage Gvr { get; } = new OcrSkillLanguage(GvrValue);
        /// <summary> Haitian Creole. </summary>
        public static OcrSkillLanguage Ht { get; } = new OcrSkillLanguage(HtValue);
        /// <summary> Halbi (Devanagiri). </summary>
        public static OcrSkillLanguage Hlb { get; } = new OcrSkillLanguage(HlbValue);
        /// <summary> Hani. </summary>
        public static OcrSkillLanguage Hni { get; } = new OcrSkillLanguage(HniValue);
        /// <summary> Haryanvi. </summary>
        public static OcrSkillLanguage Bgc { get; } = new OcrSkillLanguage(BgcValue);
        /// <summary> Hawaiian. </summary>
        public static OcrSkillLanguage Haw { get; } = new OcrSkillLanguage(HawValue);
        /// <summary> Hindi. </summary>
        public static OcrSkillLanguage Hi { get; } = new OcrSkillLanguage(HiValue);
        /// <summary> Hmong Daw (Latin). </summary>
        public static OcrSkillLanguage Mww { get; } = new OcrSkillLanguage(MwwValue);
        /// <summary> Ho (Devanagiri). </summary>
        public static OcrSkillLanguage Hoc { get; } = new OcrSkillLanguage(HocValue);
        /// <summary> Hungarian. </summary>
        public static OcrSkillLanguage Hu { get; } = new OcrSkillLanguage(HuValue);
        /// <summary> Icelandic. </summary>
        public static OcrSkillLanguage Is { get; } = new OcrSkillLanguage(IsValue);
        /// <summary> Inari Sami. </summary>
        public static OcrSkillLanguage Smn { get; } = new OcrSkillLanguage(SmnValue);
        /// <summary> Indonesian. </summary>
        public static OcrSkillLanguage Id { get; } = new OcrSkillLanguage(IdValue);
        /// <summary> Interlingua. </summary>
        public static OcrSkillLanguage Ia { get; } = new OcrSkillLanguage(IaValue);
        /// <summary> Inuktitut (Latin). </summary>
        public static OcrSkillLanguage Iu { get; } = new OcrSkillLanguage(IuValue);
        /// <summary> Irish. </summary>
        public static OcrSkillLanguage Ga { get; } = new OcrSkillLanguage(GaValue);
        /// <summary> Italian. </summary>
        public static OcrSkillLanguage It { get; } = new OcrSkillLanguage(ItValue);
        /// <summary> Japanese. </summary>
        public static OcrSkillLanguage Ja { get; } = new OcrSkillLanguage(JaValue);
        /// <summary> Jaunsari (Devanagiri). </summary>
        public static OcrSkillLanguage Jns { get; } = new OcrSkillLanguage(JnsValue);
        /// <summary> Javanese. </summary>
        public static OcrSkillLanguage Jv { get; } = new OcrSkillLanguage(JvValue);
        /// <summary> Kabuverdianu. </summary>
        public static OcrSkillLanguage Kea { get; } = new OcrSkillLanguage(KeaValue);
        /// <summary> Kachin (Latin). </summary>
        public static OcrSkillLanguage Kac { get; } = new OcrSkillLanguage(KacValue);
        /// <summary> Kangri (Devanagiri). </summary>
        public static OcrSkillLanguage Xnr { get; } = new OcrSkillLanguage(XnrValue);
        /// <summary> Karachay-Balkar. </summary>
        public static OcrSkillLanguage Krc { get; } = new OcrSkillLanguage(KrcValue);
        /// <summary> Kara-Kalpak (Cyrillic). </summary>
        public static OcrSkillLanguage KaaCyrl { get; } = new OcrSkillLanguage(KaaCyrlValue);
        /// <summary> Kara-Kalpak (Latin). </summary>
        public static OcrSkillLanguage Kaa { get; } = new OcrSkillLanguage(KaaValue);
        /// <summary> Kashubian. </summary>
        public static OcrSkillLanguage Csb { get; } = new OcrSkillLanguage(CsbValue);
        /// <summary> Kazakh (Cyrillic). </summary>
        public static OcrSkillLanguage KkCyrl { get; } = new OcrSkillLanguage(KkCyrlValue);
        /// <summary> Kazakh (Latin). </summary>
        public static OcrSkillLanguage KkLatn { get; } = new OcrSkillLanguage(KkLatnValue);
        /// <summary> Khaling. </summary>
        public static OcrSkillLanguage Klr { get; } = new OcrSkillLanguage(KlrValue);
        /// <summary> Khasi. </summary>
        public static OcrSkillLanguage Kha { get; } = new OcrSkillLanguage(KhaValue);
        /// <summary> K&apos;iche&apos;. </summary>
        public static OcrSkillLanguage Quc { get; } = new OcrSkillLanguage(QucValue);
        /// <summary> Korean. </summary>
        public static OcrSkillLanguage Ko { get; } = new OcrSkillLanguage(KoValue);
        /// <summary> Korku. </summary>
        public static OcrSkillLanguage Kfq { get; } = new OcrSkillLanguage(KfqValue);
        /// <summary> Koryak. </summary>
        public static OcrSkillLanguage Kpy { get; } = new OcrSkillLanguage(KpyValue);
        /// <summary> Kosraean. </summary>
        public static OcrSkillLanguage Kos { get; } = new OcrSkillLanguage(KosValue);
        /// <summary> Kumyk (Cyrillic). </summary>
        public static OcrSkillLanguage Kum { get; } = new OcrSkillLanguage(KumValue);
        /// <summary> Kurdish (Arabic). </summary>
        public static OcrSkillLanguage KuArab { get; } = new OcrSkillLanguage(KuArabValue);
        /// <summary> Kurdish (Latin). </summary>
        public static OcrSkillLanguage KuLatn { get; } = new OcrSkillLanguage(KuLatnValue);
        /// <summary> Kurukh (Devanagiri). </summary>
        public static OcrSkillLanguage Kru { get; } = new OcrSkillLanguage(KruValue);
        /// <summary> Kyrgyz (Cyrillic). </summary>
        public static OcrSkillLanguage Ky { get; } = new OcrSkillLanguage(KyValue);
        /// <summary> Lakota. </summary>
        public static OcrSkillLanguage Lkt { get; } = new OcrSkillLanguage(LktValue);
        /// <summary> Latin. </summary>
        public static OcrSkillLanguage La { get; } = new OcrSkillLanguage(LaValue);
        /// <summary> Lithuanian. </summary>
        public static OcrSkillLanguage Lt { get; } = new OcrSkillLanguage(LtValue);
        /// <summary> Lower Sorbian. </summary>
        public static OcrSkillLanguage Dsb { get; } = new OcrSkillLanguage(DsbValue);
        /// <summary> Lule Sami. </summary>
        public static OcrSkillLanguage Smj { get; } = new OcrSkillLanguage(SmjValue);
        /// <summary> Luxembourgish. </summary>
        public static OcrSkillLanguage Lb { get; } = new OcrSkillLanguage(LbValue);
        /// <summary> Mahasu Pahari (Devanagiri). </summary>
        public static OcrSkillLanguage Bfz { get; } = new OcrSkillLanguage(BfzValue);
        /// <summary> Malay (Latin). </summary>
        public static OcrSkillLanguage Ms { get; } = new OcrSkillLanguage(MsValue);
        /// <summary> Maltese. </summary>
        public static OcrSkillLanguage Mt { get; } = new OcrSkillLanguage(MtValue);
        /// <summary> Malto (Devanagiri). </summary>
        public static OcrSkillLanguage Kmj { get; } = new OcrSkillLanguage(KmjValue);
        /// <summary> Manx. </summary>
        public static OcrSkillLanguage Gv { get; } = new OcrSkillLanguage(GvValue);
        /// <summary> Maori. </summary>
        public static OcrSkillLanguage Mi { get; } = new OcrSkillLanguage(MiValue);
        /// <summary> Marathi. </summary>
        public static OcrSkillLanguage Mr { get; } = new OcrSkillLanguage(MrValue);
        /// <summary> Mongolian (Cyrillic). </summary>
        public static OcrSkillLanguage Mn { get; } = new OcrSkillLanguage(MnValue);
        /// <summary> Montenegrin (Cyrillic). </summary>
        public static OcrSkillLanguage CnrCyrl { get; } = new OcrSkillLanguage(CnrCyrlValue);
        /// <summary> Montenegrin (Latin). </summary>
        public static OcrSkillLanguage CnrLatn { get; } = new OcrSkillLanguage(CnrLatnValue);
        /// <summary> Neapolitan. </summary>
        public static OcrSkillLanguage Nap { get; } = new OcrSkillLanguage(NapValue);
        /// <summary> Nepali. </summary>
        public static OcrSkillLanguage Ne { get; } = new OcrSkillLanguage(NeValue);
        /// <summary> Niuean. </summary>
        public static OcrSkillLanguage Niu { get; } = new OcrSkillLanguage(NiuValue);
        /// <summary> Nogay. </summary>
        public static OcrSkillLanguage Nog { get; } = new OcrSkillLanguage(NogValue);
        /// <summary> Northern Sami (Latin). </summary>
        public static OcrSkillLanguage Sme { get; } = new OcrSkillLanguage(SmeValue);
        /// <summary> Norwegian. </summary>
        public static OcrSkillLanguage Nb { get; } = new OcrSkillLanguage(NbValue);
        /// <summary> Norwegian. </summary>
        public static OcrSkillLanguage No { get; } = new OcrSkillLanguage(NoValue);
        /// <summary> Occitan. </summary>
        public static OcrSkillLanguage Oc { get; } = new OcrSkillLanguage(OcValue);
        /// <summary> Ossetic. </summary>
        public static OcrSkillLanguage Os { get; } = new OcrSkillLanguage(OsValue);
        /// <summary> Pashto. </summary>
        public static OcrSkillLanguage Ps { get; } = new OcrSkillLanguage(PsValue);
        /// <summary> Persian. </summary>
        public static OcrSkillLanguage Fa { get; } = new OcrSkillLanguage(FaValue);
        /// <summary> Polish. </summary>
        public static OcrSkillLanguage Pl { get; } = new OcrSkillLanguage(PlValue);
        /// <summary> Portuguese. </summary>
        public static OcrSkillLanguage Pt { get; } = new OcrSkillLanguage(PtValue);
        /// <summary> Punjabi (Arabic). </summary>
        public static OcrSkillLanguage Pa { get; } = new OcrSkillLanguage(PaValue);
        /// <summary> Ripuarian. </summary>
        public static OcrSkillLanguage Ksh { get; } = new OcrSkillLanguage(KshValue);
        /// <summary> Romanian. </summary>
        public static OcrSkillLanguage Ro { get; } = new OcrSkillLanguage(RoValue);
        /// <summary> Romansh. </summary>
        public static OcrSkillLanguage Rm { get; } = new OcrSkillLanguage(RmValue);
        /// <summary> Russian. </summary>
        public static OcrSkillLanguage Ru { get; } = new OcrSkillLanguage(RuValue);
        /// <summary> Sadri (Devanagiri). </summary>
        public static OcrSkillLanguage Sck { get; } = new OcrSkillLanguage(SckValue);
        /// <summary> Samoan (Latin). </summary>
        public static OcrSkillLanguage Sm { get; } = new OcrSkillLanguage(SmValue);
        /// <summary> Sanskrit (Devanagiri). </summary>
        public static OcrSkillLanguage Sa { get; } = new OcrSkillLanguage(SaValue);
        /// <summary> Santali (Devanagiri). </summary>
        public static OcrSkillLanguage Sat { get; } = new OcrSkillLanguage(SatValue);
        /// <summary> Scots. </summary>
        public static OcrSkillLanguage Sco { get; } = new OcrSkillLanguage(ScoValue);
        /// <summary> Scottish Gaelic. </summary>
        public static OcrSkillLanguage Gd { get; } = new OcrSkillLanguage(GdValue);
        /// <summary> Serbian (Latin). </summary>
        public static OcrSkillLanguage Sr { get; } = new OcrSkillLanguage(SrValue);
        /// <summary> Serbian (Cyrillic). </summary>
        public static OcrSkillLanguage SrCyrl { get; } = new OcrSkillLanguage(SrCyrlValue);
        /// <summary> Serbian (Latin). </summary>
        public static OcrSkillLanguage SrLatn { get; } = new OcrSkillLanguage(SrLatnValue);
        /// <summary> Sherpa (Devanagiri). </summary>
        public static OcrSkillLanguage Xsr { get; } = new OcrSkillLanguage(XsrValue);
        /// <summary> Sirmauri (Devanagiri). </summary>
        public static OcrSkillLanguage Srx { get; } = new OcrSkillLanguage(SrxValue);
        /// <summary> Skolt Sami. </summary>
        public static OcrSkillLanguage Sms { get; } = new OcrSkillLanguage(SmsValue);
        /// <summary> Slovak. </summary>
        public static OcrSkillLanguage Sk { get; } = new OcrSkillLanguage(SkValue);
        /// <summary> Slovenian. </summary>
        public static OcrSkillLanguage Sl { get; } = new OcrSkillLanguage(SlValue);
        /// <summary> Somali (Arabic). </summary>
        public static OcrSkillLanguage So { get; } = new OcrSkillLanguage(SoValue);
        /// <summary> Southern Sami. </summary>
        public static OcrSkillLanguage Sma { get; } = new OcrSkillLanguage(SmaValue);
        /// <summary> Spanish. </summary>
        public static OcrSkillLanguage Es { get; } = new OcrSkillLanguage(EsValue);
        /// <summary> Swahili (Latin). </summary>
        public static OcrSkillLanguage Sw { get; } = new OcrSkillLanguage(SwValue);
        /// <summary> Swedish. </summary>
        public static OcrSkillLanguage Sv { get; } = new OcrSkillLanguage(SvValue);
        /// <summary> Tajik (Cyrillic). </summary>
        public static OcrSkillLanguage Tg { get; } = new OcrSkillLanguage(TgValue);
        /// <summary> Tatar (Latin). </summary>
        public static OcrSkillLanguage Tt { get; } = new OcrSkillLanguage(TtValue);
        /// <summary> Tetum. </summary>
        public static OcrSkillLanguage Tet { get; } = new OcrSkillLanguage(TetValue);
        /// <summary> Thangmi. </summary>
        public static OcrSkillLanguage Thf { get; } = new OcrSkillLanguage(ThfValue);
        /// <summary> Tongan. </summary>
        public static OcrSkillLanguage To { get; } = new OcrSkillLanguage(ToValue);
        /// <summary> Turkish. </summary>
        public static OcrSkillLanguage Tr { get; } = new OcrSkillLanguage(TrValue);
        /// <summary> Turkmen (Latin). </summary>
        public static OcrSkillLanguage Tk { get; } = new OcrSkillLanguage(TkValue);
        /// <summary> Tuvan. </summary>
        public static OcrSkillLanguage Tyv { get; } = new OcrSkillLanguage(TyvValue);
        /// <summary> Upper Sorbian. </summary>
        public static OcrSkillLanguage Hsb { get; } = new OcrSkillLanguage(HsbValue);
        /// <summary> Urdu. </summary>
        public static OcrSkillLanguage Ur { get; } = new OcrSkillLanguage(UrValue);
        /// <summary> Uyghur (Arabic). </summary>
        public static OcrSkillLanguage Ug { get; } = new OcrSkillLanguage(UgValue);
        /// <summary> Uzbek (Arabic). </summary>
        public static OcrSkillLanguage UzArab { get; } = new OcrSkillLanguage(UzArabValue);
        /// <summary> Uzbek (Cyrillic). </summary>
        public static OcrSkillLanguage UzCyrl { get; } = new OcrSkillLanguage(UzCyrlValue);
        /// <summary> Uzbek (Latin). </summary>
        public static OcrSkillLanguage Uz { get; } = new OcrSkillLanguage(UzValue);
        /// <summary> Volapük. </summary>
        public static OcrSkillLanguage Vo { get; } = new OcrSkillLanguage(VoValue);
        /// <summary> Walser. </summary>
        public static OcrSkillLanguage Wae { get; } = new OcrSkillLanguage(WaeValue);
        /// <summary> Welsh. </summary>
        public static OcrSkillLanguage Cy { get; } = new OcrSkillLanguage(CyValue);
        /// <summary> Western Frisian. </summary>
        public static OcrSkillLanguage Fy { get; } = new OcrSkillLanguage(FyValue);
        /// <summary> Yucatec Maya. </summary>
        public static OcrSkillLanguage Yua { get; } = new OcrSkillLanguage(YuaValue);
        /// <summary> Zhuang. </summary>
        public static OcrSkillLanguage Za { get; } = new OcrSkillLanguage(ZaValue);
        /// <summary> Zulu. </summary>
        public static OcrSkillLanguage Zu { get; } = new OcrSkillLanguage(ZuValue);
        /// <summary> Unknown (All). </summary>
        public static OcrSkillLanguage Unk { get; } = new OcrSkillLanguage(UnkValue);
        /// <summary> Determines if two <see cref="OcrSkillLanguage"/> values are the same. </summary>
        public static bool operator ==(OcrSkillLanguage left, OcrSkillLanguage right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OcrSkillLanguage"/> values are not the same. </summary>
        public static bool operator !=(OcrSkillLanguage left, OcrSkillLanguage right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OcrSkillLanguage"/>. </summary>
        public static implicit operator OcrSkillLanguage(string value) => new OcrSkillLanguage(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OcrSkillLanguage other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OcrSkillLanguage other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
