/*************************************************************************************************
  Required Notice: Copyright (C) EPPlus Software AB. 
  This software is licensed under PolyForm Noncommercial License 1.0.0 
  and may only be used for noncommercial purposes 
  https://polyformproject.org/licenses/noncommercial/1.0.0/

  A commercial license to use this software can be purchased at https://epplussoftware.com
 *************************************************************************************************
  Date               Author                       Change
 *************************************************************************************************
  01/27/2020         EPPlus Software AB       Initial release EPPlus 5
 *************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Database;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Logical;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Numeric;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Information;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Finance;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Engineering;

namespace OfficeOpenXml.FormulaParsing.Excel.Functions
{
    public class BuiltInFunctions : FunctionsModule
    {
        public BuiltInFunctions()
        {
            // Text
            Functions["len"] = new Len();
            Functions["lower"] = new Lower();
            Functions["upper"] = new Upper();
            Functions["left"] = new Left();
            Functions["right"] = new Right();
            Functions["mid"] = new Mid();
            Functions["replace"] = new Replace();
            Functions["rept"] = new Rept();
            Functions["substitute"] = new Substitute();
            Functions["concatenate"] = new Concatenate();
            Functions["concat"] = new Concat();
            Functions["char"] = new CharFunction();
            Functions["exact"] = new Exact();
            Functions["find"] = new Find();
            Functions["fixed"] = new Fixed();
            Functions["proper"] = new Proper();
            Functions["search"] = new Search();
            Functions["text"] = new Text.Text();
            Functions["t"] = new T();
            Functions["hyperlink"] = new Hyperlink();
            Functions["value"] = new Value();
            Functions["trim"] = new Trim();
            Functions["clean"] = new Clean();
            Functions["unicode"] = new Unicode();
            Functions["unichar"] = new Unichar();
            Functions["numbervalue"] = new NumberValue();
            // Numbers
            Functions["int"] = new CInt();
            // Math
            Functions["abs"] = new Abs();
            Functions["asin"] = new Asin();
            Functions["asinh"] = new Asinh();
            Functions["acot"] = new Acot();
            Functions["acoth"] = new Acoth();
            Functions["cos"] = new Cos();
            Functions["cot"] = new Cot();
            Functions["coth"] = new Coth();
            Functions["cosh"] = new Cosh();
            Functions["csc"] = new Csc();
            Functions["csch"] = new Csch();
            Functions["power"] = new Power();
            Functions["gcd"] = new Gcd();
            Functions["lcm"] = new Lcm();
            Functions["sec"] = new Sec();
            Functions["sech"] = new SecH();
            Functions["sign"] = new Sign();
            Functions["sqrt"] = new Sqrt();
            Functions["sqrtpi"] = new SqrtPi();
            Functions["pi"] = new Pi();
            Functions["product"] = new Product();
            Functions["ceiling"] = new Ceiling();
            Functions["ceiling.precise"] = new CeilingPrecise();
            Functions["ceiling.math"] = new CeilingMath();
            Functions["iso.ceiling"] = new IsoCeiling();
            Functions["combin"] = new Combin();
            Functions["combina"] = new Combina();
            Functions["count"] = new Count();
            Functions["counta"] = new CountA();
            Functions["countblank"] = new CountBlank();
            Functions["countif"] = new CountIf();
            Functions["countifs"] = new CountIfs();
            Functions["fact"] = new Fact();
            Functions["factdouble"] = new FactDouble();
            Functions["floor"] = new Floor();
            Functions["floor.precise"] = new FloorPrecise();
            Functions["floor.math"] = new FloorMath();
            Functions["radians"] = new Radians();
            Functions["roman"] = new Roman();
            Functions["sin"] = new Sin();
            Functions["sinh"] = new Sinh();
            Functions["sum"] = new Sum();
            Functions["sumif"] = new SumIf();
            Functions["sumifs"] = new SumIfs();
            Functions["sumproduct"] = new SumProduct();
            Functions["sumsq"] = new Sumsq();
            Functions["sumxmy2"] = new Sumxmy2();
            Functions["sumx2my2"] = new SumX2mY2();
            Functions["sumx2py2"] = new SumX2pY2();
            Functions["seriessum"] = new Seriessum();
            Functions["stdev"] = new Stdev();
            Functions["stdevp"] = new StdevP();
            Functions["stdev.s"] = new Stdev();
            Functions["stdev.p"] = new StdevP();
            Functions["subtotal"] = new Subtotal();
            Functions["exp"] = new Exp();
            Functions["log"] = new Log();
            Functions["log10"] = new Log10();
            Functions["ln"] = new Ln();
            Functions["max"] = new Max();
            Functions["maxa"] = new Maxa();
            Functions["median"] = new Median();
            Functions["min"] = new Min();
            Functions["mina"] = new Mina();
            Functions["mod"] = new Mod();
            Functions["mround"] = new Mround();
            Functions["average"] = new Average();
            Functions["averagea"] = new AverageA();
            Functions["averageif"] = new AverageIf();
            Functions["averageifs"] = new AverageIfs();
            Functions["round"] = new Round();
            Functions["rounddown"] = new Rounddown();
            Functions["roundup"] = new Roundup();
            Functions["rand"] = new Rand();
            Functions["randbetween"] = new RandBetween();
            Functions["rank"] = new Rank();
            Functions["rank.eq"] = new Rank();
            Functions["rank.avg"] = new Rank(true);
            Functions["quotient"] = new Quotient();
            Functions["trunc"] = new Trunc();
            Functions["tan"] = new Tan();
            Functions["tanh"] = new Tanh();
            Functions["atan"] = new Atan();
            Functions["atan2"] = new Atan2();
            Functions["atanh"] = new Atanh();
            Functions["acos"] = new Acos();
            Functions["acosh"] = new Acosh();
            Functions["var"] = new Var();
            Functions["varp"] = new VarP();
            Functions["large"] = new Large();
            Functions["small"] = new Small();
            Functions["degrees"] = new Degrees();
            Functions["odd"] = new Odd();
            Functions["even"] = new Even();
            // Information
            Functions["isblank"] = new IsBlank();
            Functions["isnumber"] = new IsNumber();
            Functions["istext"] = new IsText();
            Functions["isnontext"] = new IsNonText();
            Functions["iserror"] = new IsError();
            Functions["iserr"] = new IsErr();
            Functions["error.type"] = new ErrorType();
            Functions["iseven"] = new IsEven();
            Functions["isodd"] = new IsOdd();
            Functions["islogical"] = new IsLogical();
            Functions["isna"] = new IsNa();
            Functions["na"] = new Na();
            Functions["n"] = new N();
            Functions["type"] = new TypeFunction();
            // Logical
            Functions["if"] = new If();
            Functions["ifs"] = new Ifs();
            Functions["iferror"] = new IfError();
            Functions["ifna"] = new IfNa();
            Functions["not"] = new Not();
            Functions["and"] = new And();
            Functions["or"] = new Or();
            Functions["true"] = new True();
            Functions["false"] = new False();
            Functions["switch"] = new Switch();
            // Reference and lookup
            Functions["address"] = new Address();
            Functions["hlookup"] = new HLookup();
            Functions["vlookup"] = new VLookup();
            Functions["lookup"] = new Lookup();
            Functions["match"] = new Match();
            Functions["row"] = new Row();
            Functions["rows"] = new Rows();
            Functions["column"] = new Column();
            Functions["columns"] = new Columns();
            Functions["choose"] = new Choose();
            Functions["index"] = new RefAndLookup.Index();
            Functions["indirect"] = new Indirect();
            Functions["offset"] = new Offset();
            // Date
            Functions["date"] = new Date();
            Functions["today"] = new Today();
            Functions["now"] = new Now();
            Functions["day"] = new Day();
            Functions["month"] = new Month();
            Functions["year"] = new Year();
            Functions["time"] = new Time();
            Functions["hour"] = new Hour();
            Functions["minute"] = new Minute();
            Functions["second"] = new Second();
            Functions["weeknum"] = new Weeknum();
            Functions["weekday"] = new Weekday();
            Functions["days"] = new Days();
            Functions["days360"] = new Days360();
            Functions["yearfrac"] = new Yearfrac();
            Functions["edate"] = new Edate();
            Functions["eomonth"] = new Eomonth();
            Functions["isoweeknum"] = new IsoWeekNum();
            Functions["workday"] = new Workday();
            Functions["workday.intl"] = new WorkdayIntl();
            Functions["networkdays"] = new Networkdays();
            Functions["networkdays.intl"] = new NetworkdaysIntl();
            Functions["datevalue"] = new DateValue();
            Functions["timevalue"] = new TimeValue();
            // Database
            Functions["dget"] = new Dget();
            Functions["dcount"] = new Dcount();
            Functions["dcounta"] = new DcountA();
            Functions["dmax"] = new Dmax();
            Functions["dmin"] = new Dmin();
            Functions["dsum"] = new Dsum();
            Functions["daverage"] = new Daverage();
            Functions["dvar"] = new Dvar();
            Functions["dvarp"] = new Dvarp();
            //Finance
            Functions["ddb"] = new Ddb();
            Functions["effect"] = new Effect();
            Functions["fvschedule"] = new FvSchedule();
            Functions["pduration"] = new Pduration();
            Functions["rri"] = new Rri();
            Functions["pmt"] = new Pmt();
            Functions["ppmt"] = new Ppmt();
            Functions["ipmt"] = new Ipmt();
            Functions["ispmt"] = new IsPmt();
            Functions["pv"] = new Pv();
            Functions["fv"] = new Fv();
            Functions["npv"] = new Npv();
            Functions["rate"] = new Rate();
            Functions["nper"] = new Nper();
            Functions["nominal"] = new Nominal();
            Functions["irr"] = new Irr();
            Functions["mirr"] = new Mirr();
            Functions["sln"] = new Sln();
            Functions["syd"] = new Syd();
            Functions["xnpv"] = new Xnpv();
            Functions["coupdays"] = new Coupdays();
            Functions["coupdaysnc"] = new Coupdaysnc();
            Functions["coupdaybs"] = new Coupdaybs();
            Functions["coupnum"] = new Coupnum();
            Functions["coupncd"] = new Coupncd();
            Functions["couppcd"] = new Couppcd();
            //Engineering
            Functions["bitand"] = new BitAnd();
            Functions["bitor"] = new BitOr();
            Functions["bitxor"] = new BitXor();
            Functions["bitlshift"] = new BitLshift();
            Functions["bitrshift"] = new BitRshift();
            Functions["convert"] = new ConvertFunction();
            Functions["bin2dec"] = new Bin2Dec();
            Functions["bin2hex"] = new Bin2Hex();
            Functions["bin2oct"] = new Bin2Oct();
            Functions["dec2bin"] = new Dec2Bin();
            Functions["dec2hex"] = new Dec2Hex();
            Functions["dec2oct"] = new Dec2Oct();
            Functions["hex2bin"] = new Hex2Bin();
            Functions["hex2dec"] = new Hex2Dec();
            Functions["hex2oct"] = new Hex2Oct();
            Functions["oct2bin"] = new Oct2Bin();
            Functions["oct2dec"] = new Oct2Dec();
            Functions["oct2hex"] = new Oct2Hex();
            Functions["delta"] = new Delta();
        }
    }
}
