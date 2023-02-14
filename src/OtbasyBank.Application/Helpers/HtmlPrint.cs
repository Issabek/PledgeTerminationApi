﻿using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.DependencyInjection;
using OtbasyBank.Shared.CustomModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtbasyBank.Application.Helpers
{
    public class HtmlPrint
    { 

        public static string GetRequisite(PaymentData model, string operDate)
        {
            string html = GetRequisiteStyle() + @"<div class='titlePdf'>" + model?.serviceName + @"</div>
<div style='margin: 30px 0'>
    <table>
        <tr>
            <td>
                <svg width='27' height='35' viewBox='0 0 27 35' fill='none' xmlns='http://www.w3.org/2000/svg' style='margin-left: 10px'>
                    <path d='M25.9434 0.912298C25.2951 0.616753 24.5344 0.731802 24.0055 1.2044L21.8517 3.09685L18.8796 0.458301C18.1924 -0.152767 17.1561 -0.152767 16.4689 0.458301L13.5003 3.09409L10.5309 0.458301C9.84376 -0.152767 8.80678 -0.152767 8.11962 0.458301L5.14679 3.09685L2.99091 1.2044C2.25031 0.550617 1.11198 0.617443 0.453977 1.35252C0.15829 1.68251 -0.00274109 2.10826 3.5311e-05 2.54847V32.4502C-0.00551749 33.4346 0.796862 34.2407 1.78873 34.2468H1.79914C2.24059 34.2468 2.66469 34.087 2.99438 33.7956L5.14818 31.9032L8.12031 34.5417C8.46389 34.8476 8.89493 34.9998 9.32596 34.9998C9.757 34.9998 10.188 34.8469 10.5316 34.5417L13.5003 31.9059L16.4696 34.5417C17.1568 35.1528 18.1938 35.1528 18.8809 34.5417L21.8538 31.9032L24.009 33.7956C24.3678 34.1125 24.8287 34.2716 25.3083 34.2434C25.7872 34.2152 26.2273 34.0043 26.5459 33.6482C26.8416 33.3182 27.0033 32.8924 26.9998 32.4515V2.55054C27.0096 1.84302 26.5945 1.20026 25.9434 0.912298ZM1.97406 2.9322L3.95224 4.67171C4.63871 5.2752 5.67153 5.27244 6.35452 4.66551L9.32596 2.02765L12.2946 4.66275C12.9818 5.27382 14.0188 5.27382 14.7059 4.66275L17.6753 2.02696L20.6474 4.66482C21.329 5.27245 22.3591 5.2752 23.0435 4.67102L25.0175 2.93151L25.0251 32.0678L23.0476 30.3283C22.3612 29.7248 21.3283 29.7276 20.6453 30.3345L17.6739 32.9724L14.7052 30.3366C14.0181 29.7255 12.9811 29.7255 12.2939 30.3366L9.32457 32.9724L6.35244 30.3345C6.01025 30.0293 5.5806 29.8771 5.15095 29.8771C4.72408 29.8771 4.29721 30.0272 3.95641 30.3283L1.98239 32.0678L1.97406 2.9322Z' fill='#878A8A'/>
                    <path d='M5.75 18.4838H21.25C21.7962 18.4838 22.2411 18.0422 22.2411 17.5C22.2411 16.9578 21.7962 16.5162 21.25 16.5162H5.75C5.20375 16.5162 4.75883 16.9578 4.75883 17.5C4.75883 18.0422 5.20375 18.4838 5.75 18.4838Z' fill='#878A8A'/>
                    <path d='M5.75 13.6152H13.8918C14.4381 13.6152 14.883 13.1736 14.883 12.6314C14.883 12.0893 14.4381 11.6477 13.8918 11.6477H5.75C5.20375 11.6477 4.75883 12.0893 4.75883 12.6314C4.75883 13.1736 5.20375 13.6152 5.75 13.6152Z' fill='#878A8A'/>
                    <path d='M5.75 23.3523H21.25C21.7962 23.3523 22.2411 22.9108 22.2411 22.3686C22.2411 21.8264 21.7962 21.3848 21.25 21.3848H5.75C5.20375 21.3848 4.75883 21.8264 4.75883 22.3686C4.75883 22.9114 5.20375 23.3523 5.75 23.3523Z' fill='#878A8A'/>
                </svg>
            </td>
            <td>
                <div style='margin-left: 15px;'>
                    <p class='billNumber'> {Квитанция} {RequisiteNumber}</p>
                    <p class='date'>" + operDate + @"</p>
                </div>
            </td>
        </tr>
    </table>
</div>


<hr>
<div style='margin: 30px 0'>
    <table>
        <tr>
                <td class='gtxt'>{сумма}</td>
                <td><p class='btxt'>" + model?.amountPay + @" тенге</p></td>
        </tr>
        <tr>
                <td class='gtxt'>{комиссия}</td>
                <td><p class='btxt'>" + 0 + @" тенге</p></td>
        </tr>
        <tr>
                <td class='gtxt'>{назначение_платежа}</td>
                <td><p class='btxt'>" + model?.knpName + @"</p></td>
        </tr>
        <tr>
                <td class='gtxt'>{кнп}</td>
                <td><p class='btxt'>" + model?.knp + @"</p></td>
        </tr>
        <tr>
                <td class='gtxt'>{Код_получателя}</td>
                <td><p  class='btxt'>" + model?.kno + @"</p></td>
        </tr>
        <tr>
                <td class='gtxt'>{Получатель_платежа}</td>
                <td><p class='btxt'>" + model?.noName + @"</p></td>
        </tr>
        <tr>
                <td class='gtxt'>{Номер_счета_получателя}</td>
                <td><p class='btxt'>" + model?.noAccount + @"</p></td>
        </tr>
        <tr>
                <td class='gtxt'>{Квитанция_оплачена}</td>
                <td ><p class='btxt'>" + operDate + @"</p></td>
        </tr>
        <tr>
                <td class='gtxt'>{Плательщик}</td>
                <td><p class='btxt'>{ао_жилстройсбербанк_казахстана}</p></td>
        </tr>
        {TransactionNumber}
    </table>
</div>  

<hr>
<div style='margin: 30px 0'>
    <table>
        <tr>
            <td style='width: 80%'>
                <div class='btxt'>{подпись} {otpSignature}</div>
            </td>
            <td>
            <div>
                " + GetBankLogo() + @"
            </div>
            </td>
        </tr>
    </table>
</div>
";
            return html;
        }
        public static string GetLetterEncumbrances(PledgeTerminateModel model)
        {
            string applicant = @"<div>
	            </br>
	            </br>
	
	            </br>
	            </br>
	            <table style='width:100%'>
		            <tr>
			            <td>Дата " + DateTime.Now.ToString("dd.MM.yyyy") + @"</td>
		            </tr>
		            <tr>
			            <td>№ " + model.data.RegNum + @"</td>
		            </tr>
		            <tr>
			            <td style = 'width:50%; float:left'></td>
			            <td style = 'float:right'> В компетентные органы </td>
		            </tr>
	            </table>
	            </br>
	            </br>

	            <div style='text-align:center'>
		            <b>Уведомление о снятии обременения</b>
		            </br>
	            </div>
	
	            <p><span style='padding-right:30px;'></span>Настоящим АО «Отбасы банк» (далее - Банк) сообщает, что в соответствии с Договором 
		            банковского займа № " + model.data.LnCode + @" от " + model.data.DateBegin + @" заемщик " + model.data.CliLongName + @" полностью погасил задолженность по указанному договору. 
	            </p>
	            <p><span style='padding-right:30px;'></span>В связи с изложенным, Банк снимает обременение с обеспечения в виде недвижимости, 
		            расположенной по адресу: " + model.data.FltAddress + @", принятой Банком в залог по договору 
		            залога недвижимого имущества № " + model.data.DocNumber + @" от " + model.data.DocDate + @",";
            if (model.data.AdditionalDocNumber != null && model.data.AdditionalDocNumber.Count > 0)
            {
                applicant += "с учетом дополнительного соглашения к нему ";
                for (int i = 0; i < model.data.AdditionalDocNumber.Count; i++)
                {
                    applicant += "№ " + model.data.AdditionalDocNumber[i] + " от " + model.data.AdditionalDocDate[i] + ", ";
                }
            }

            applicant += @"залогодателем по которому выступает ";
            foreach (var cli in model.data.CliNames)
            {
                applicant += cli + ", ";
            }
            applicant += @" в качестве обеспечения исполнения обязательств по Договору банковского займа № " + model.data.LnCode + @" от " + model.data.DateBegin + @".
	            </p>
	            </br>
	            </br>
	            <table style = 'width:100%'>
			            <tr>
				            <td style = 'float:left'> 
                                Уполномоченное лицо
                                </br>
                                Заместитель председателя правления - Акшанов Н.С.
                                </br>
                                Подписано ЭЦП  " + DateTime.Now.ToString("dd.MM.yyyy") + @" г.
                            </td>
			            </tr>
	            </table>
            </div>";

            return applicant;
        }

        public static string GetLetterEncumbrancesKz(PledgeTerminateModel model)
        {
            string applicant = @"<div>
	            </br>
	            </br>
	
	            </br>
	            </br>
	            <table style='width:100%'>
		            <tr>
			            <td>Күні " + DateTime.Now.ToString("dd.MM.yyyy") + @"</td>
		            </tr>
		            <tr>
			            <td>№ " + model.data.RegNum + @"</td>
		            </tr>
		            <tr>
			            <td style = 'width:50%; float:left'></td>
			            <td style = 'float:right'> Құзыретті органдарға </td>
		            </tr>
	            </table>
	            </br>
	            </br>

	            <div style='text-align:center'>
		            <b>Ауыртпалықтың алынғаны туралы хабарлама</b>
		            </br>
	            </div>
	
	            <p><span style='padding-right:30px;'></span>Осы арқылы «Отбасы банк» АҚ (бұдан әрі - Банк) " + model.data.DateBegin + @" жылғы № " + model.data.LnCode +
                @" </p>
	            <p><span style='padding-right:30px;'></span>
                    Баяндалғанға байланысты Банк ол бойынша кепіл беруші ";
            for (int i = 0; i < model.data.CliNames.Count; i++)
            {
                applicant += model.data.CliNames[0];
                if (i != model.data.CliNames.Count - 1)
                    applicant += ", ";
            }
            applicant += @" болып табылатын  " + model.data.DateBegin + @" жылғы № " + model.data.LnCode + @" жылжымайтын мүлік кепілі шарты бойынша, ";
            if (model.data.AdditionalDocNumber != null && model.data.AdditionalDocNumber.Count > 0)
            {
                applicant += "оған жасалған ";
                for (int i = 0; i < model.data.AdditionalDocNumber.Count; i++)
                {
                    applicant += model.data.AdditionalDocDate[i] + " жылғы № " + model.data.AdditionalDocNumber[i];
                    if (i != model.data.AdditionalDocNumber.Count - 1)
                        applicant += ", ";
                }
                applicant += " қосымша келісімді ескерумен ";
            }


            applicant += "Банк  " + model.data.DocDate + @" жылғы № " + model.data.DocNumber + @" банктік қарыз шарты бойынша міндеттемелердің орындалуын 
                қамтамасыз ету ретінде кепілге қабылдаған, " + model.data.FltAddress + @" мекенжайы бойынша орналасқан жылжымайтын мүлік түріндегі қамтамасыз етуден ауыртпалықты алып тастайды.";


            applicant += @"
	            </p>
	            </br>
	            </br>
	            <table style = 'width:100%'>
			            <tr>
				            <td style = 'float:left'> Уәкілетті тұлға
                                </br>
                                Басқарма төрағасының орынбасары – Ақшанов Н.С.
                                </br>
                                ЭЦП арқылы қол қойылды " + DateTime.Now.ToString("dd.MM.yyyy") + @" ж.
                            </td>
			            </tr>
	            </table>
            </div>";

            return applicant;
        }

        private static string GetRequisiteStyle()
        {
            return @"<style>
    .titlePdf{
        text-align: left;
        font-family: Ubuntu-bold;
        font-style: normal;
        font-size: 16px;
        line-height: 18px;
        color: #2C3537;
    }
    
    .billNumber{
        font-family: Ubuntu;
        font-style: normal;
        font-weight: bold;
        font-size: 15px;
        line-height: 17px;
        color: #2C3537;
    }
    .date{
        font-family: Ubuntu;
        font-style: normal;
        font-weight: normal;
        font-size: 12px;
        line-height: 14px;
        color: #2C3537;
        margin-top: -5px;
    }
    
    .gtxt{
        font-family: Ubuntu;
        font-style: normal;
        font-weight: normal;
        font-size: 12px;
        line-height: 14px;
        color: #878A8A;
        width: 30%;
    }
    
    .btxt{
        font-family: Ubuntu;
        font-style: normal;
        font-weight: normal;
        font-size: 12px;
        line-height: 14px;
        color: #2C3537;
       margin-bottom: 15px; 
    }
    
   
    
</style>";
        }
        private static string GetBankLogo()
        {
            return @"<svg width='142' height='39' viewBox='0 0 142 39' fill='none' xmlns='http://www.w3.org/2000/svg'>
                    <path d='M22.9247 10.3038C19.8612 10.6436 14.9341 12.7423 9.78253 16.1083C5.59261 18.8452 2.11703 21.8577 0.00146484 24.4063V-0.000976562H38.4297V16.6869C38.1414 16.4942 37.8525 16.3011 37.5597 16.1083C32.4081 12.7423 27.4764 10.639 24.4175 10.3038C24.1885 10.2717 23.9413 10.2533 23.6711 10.2579C23.4009 10.2533 23.1537 10.2717 22.9247 10.3038Z' fill='#008F91'/>
                    <path d='M10.9319 18.3491C15.8591 14.5284 20.6443 11.9981 23.6711 11.4058C26.6979 11.9981 31.4877 14.5284 36.4149 18.3491C37.1063 18.8864 37.784 19.4328 38.4297 19.9839V38.8668H0.00146484V30.7525C0.88982 27.7768 5.13927 22.8448 10.9319 18.3491Z' fill='#008F91'/>
                    <path fill-rule='evenodd' clip-rule='evenodd' d='M61.7887 8.50338C61.7887 9.86327 61.583 11.0627 61.1716 12.1017C60.7755 13.1255 60.227 13.9888 59.5261 14.6916C58.8252 15.3792 57.9872 15.8987 57.0121 16.2502C56.0522 16.6016 55.0161 16.7773 53.9039 16.7773C52.8221 16.7773 51.8012 16.6016 50.8414 16.2502C49.8815 15.8987 49.0435 15.3792 48.3274 14.6916C47.6112 13.9888 47.0475 13.1255 46.6361 12.1017C46.2247 11.0627 46.019 9.86327 46.019 8.50338C46.019 7.14349 46.2324 5.95168 46.659 4.92795C47.0856 3.88893 47.657 3.01799 48.3731 2.31513C49.1044 1.61227 49.9424 1.08512 50.8871 0.73369C51.847 0.382259 52.8526 0.206543 53.9039 0.206543C54.9856 0.206543 56.0065 0.382259 56.9664 0.73369C57.9263 1.08512 58.7643 1.61227 59.4804 2.31513C60.1965 3.01799 60.7602 3.88893 61.1716 4.92795C61.583 5.95168 61.7887 7.14349 61.7887 8.50338ZM49.6986 8.50338C49.6986 9.28264 49.79 9.9855 49.9729 10.612C50.171 11.2384 50.4452 11.7809 50.7956 12.2392C51.1613 12.6824 51.6032 13.0261 52.1212 13.2706C52.6392 13.5151 53.2335 13.6373 53.9039 13.6373C54.559 13.6373 55.1456 13.5151 55.6637 13.2706C56.1969 13.0261 56.6388 12.6824 56.9892 12.2392C57.3549 11.7809 57.6292 11.2384 57.812 10.612C58.0101 9.9855 58.1091 9.28264 58.1091 8.50338C58.1091 7.72412 58.0101 7.02126 57.812 6.39479C57.6292 5.75305 57.3549 5.21062 56.9892 4.76751C56.6388 4.30912 56.1969 3.95769 55.6637 3.71322C55.1456 3.46874 54.559 3.34651 53.9039 3.34651C53.2335 3.34651 52.6392 3.47638 52.1212 3.73614C51.6032 3.98061 51.1613 4.33204 50.7956 4.79043C50.4452 5.23354 50.171 5.77597 49.9729 6.41771C49.79 7.04418 49.6986 7.7394 49.6986 8.50338Z' fill='#008F91'/>
                    <path d='M75.9723 0.573254V3.62154H71.1956V16.4564H67.6303V3.62154H62.8537V0.573254H75.9723Z' fill='#008F91'/>
                    <path fill-rule='evenodd' clip-rule='evenodd' d='M81.6689 6.21144V3.59862H88.7767V0.573254H78.2636V16.0897C79.0864 16.2883 79.9015 16.4259 80.709 16.5023C81.5318 16.5787 82.2632 16.6169 82.9031 16.6169C85.2647 16.6169 87.0778 16.189 88.3425 15.3334C89.6223 14.4624 90.2622 13.1484 90.2622 11.3912C90.2622 10.4439 90.0946 9.64171 89.7594 8.98469C89.4242 8.32766 88.9367 7.79288 88.2968 7.38033C87.6721 6.96778 86.895 6.66983 85.9656 6.48647C85.0514 6.30311 84.0077 6.21144 82.8345 6.21144H81.6689ZM84.4343 13.4769C84.0077 13.538 83.5582 13.5686 83.0859 13.5686H82.2631C82.0346 13.5533 81.8365 13.538 81.6689 13.5227V9.16804H82.7202C83.3297 9.16804 83.8782 9.1986 84.3658 9.25972C84.8533 9.32084 85.2647 9.43544 85.5999 9.60351C85.9351 9.77159 86.1941 10.0008 86.377 10.2911C86.5598 10.5814 86.6512 10.9558 86.6512 11.4141C86.6512 11.8573 86.5522 12.2163 86.3541 12.4914C86.156 12.7664 85.8894 12.9879 85.5542 13.156C85.2342 13.3088 84.8609 13.4158 84.4343 13.4769Z' fill='#008F91'/>
                    <path fill-rule='evenodd' clip-rule='evenodd' d='M103.732 16.4564C103.565 15.9064 103.374 15.341 103.161 14.7604L102.567 13.0185H96.3962C96.1981 13.5991 95.9924 14.1798 95.7791 14.7604C95.581 15.341 95.3982 15.9064 95.2306 16.4564H91.5282C92.1224 14.7451 92.6861 13.1637 93.2194 11.7121C93.7527 10.2605 94.2707 8.89301 94.7735 7.60952C95.2915 6.32603 95.7943 5.1113 96.2819 3.96533C96.7847 2.80408 97.3027 1.67339 97.836 0.573254H101.241C101.759 1.67339 102.27 2.80408 102.773 3.96533C103.275 5.1113 103.778 6.32603 104.281 7.60952C104.799 8.89301 105.325 10.2605 105.858 11.7121C106.391 13.1637 106.955 14.7451 107.549 16.4564H103.732ZM99.4587 4.17161C99.3825 4.4008 99.2682 4.71403 99.1159 5.1113C98.9635 5.50857 98.7883 5.96696 98.5902 6.48647C98.3922 7.00598 98.1712 7.57896 97.9274 8.20543C97.6989 8.83189 97.4627 9.48892 97.2189 10.1765H101.721C101.478 9.48892 101.241 8.83189 101.013 8.20543C100.784 7.57896 100.563 7.00598 100.35 6.48647C100.152 5.96696 99.9767 5.50857 99.8244 5.1113C99.672 4.71403 99.5501 4.4008 99.4587 4.17161Z' fill='#008F91'/>
                    <path d='M110.501 14.6229C111.857 16.0592 113.822 16.7773 116.397 16.7773C117.601 16.7773 118.66 16.6551 119.574 16.4106C120.488 16.1661 121.197 15.8911 121.7 15.5855L120.717 12.7206C120.519 12.8122 120.298 12.9116 120.054 13.0185C119.81 13.1255 119.528 13.2248 119.208 13.3165C118.888 13.3929 118.523 13.4616 118.111 13.5227C117.7 13.5839 117.235 13.6144 116.717 13.6144C115.895 13.6144 115.194 13.4845 114.615 13.2248C114.036 12.9498 113.563 12.583 113.198 12.1247C112.847 11.6663 112.588 11.1238 112.421 10.4974C112.268 9.85563 112.192 9.16804 112.192 8.43462C112.192 7.51784 112.314 6.73858 112.558 6.09684C112.802 5.4551 113.121 4.93559 113.518 4.53832C113.929 4.12577 114.394 3.82781 114.912 3.64446C115.445 3.4611 115.986 3.36943 116.534 3.36943C117.357 3.36943 118.089 3.4611 118.728 3.64446C119.384 3.82781 119.955 4.04937 120.443 4.30912L121.471 1.42127C121.349 1.34488 121.151 1.23792 120.877 1.1004C120.603 0.962885 120.26 0.833008 119.848 0.710771C119.437 0.573254 118.957 0.458657 118.409 0.366979C117.86 0.260022 117.251 0.206543 116.58 0.206543C115.422 0.206543 114.348 0.389899 113.358 0.756609C112.367 1.12332 111.514 1.66575 110.798 2.38389C110.082 3.08675 109.518 3.95769 109.107 4.99671C108.695 6.02044 108.49 7.18933 108.49 8.50338C108.49 11.1468 109.16 13.1866 110.501 14.6229Z' fill='#008F91'/>
                    <path fill-rule='evenodd' clip-rule='evenodd' d='M135.971 11.2537C135.971 12.1399 135.796 12.9192 135.445 13.5915C135.11 14.2638 134.622 14.8291 133.982 15.2875C133.358 15.7459 132.588 16.0897 131.674 16.3189C130.775 16.5481 129.77 16.6627 128.657 16.6627C128.017 16.6627 127.286 16.6169 126.463 16.5252C125.656 16.4335 124.833 16.2883 123.995 16.0897V0.573254H127.56V5.84473C127.728 5.82945 127.88 5.82181 128.017 5.82181H128.497C130.981 5.82181 132.847 6.26492 134.097 7.15113C135.346 8.03735 135.971 9.40488 135.971 11.2537ZM128.269 8.84717H127.949C127.812 8.84717 127.682 8.85481 127.56 8.87009V13.6144C127.728 13.6297 127.918 13.6373 128.132 13.6373H128.909C129.381 13.6373 129.823 13.5991 130.234 13.5227C130.646 13.4463 131.004 13.3165 131.308 13.1331C131.628 12.9498 131.872 12.7053 132.04 12.3997C132.223 12.0941 132.314 11.7121 132.314 11.2537C132.314 10.3217 131.964 9.68755 131.263 9.3514C130.577 9.01525 129.579 8.84717 128.269 8.84717Z' fill='#008F91'/>
                    <path d='M137.959 0.573254H141.524V16.4564H137.959V0.573254Z' fill='#008F91'/>
                    <path fill-rule='evenodd' clip-rule='evenodd' d='M53.6737 28.9374C52.79 28.7541 51.7844 28.6624 50.6569 28.6624H48.4858V23.8493H56.3477V22.4971H46.9316V38.0823C47.4801 38.2351 48.1201 38.342 48.8514 38.4032C49.598 38.4796 50.2913 38.5178 50.9312 38.5178C53.1709 38.5178 54.8698 38.1129 56.0278 37.303C57.1857 36.4779 57.7647 35.2326 57.7647 33.5672C57.7647 32.6962 57.6047 31.9475 57.2848 31.3211C56.9648 30.6946 56.5001 30.1904 55.8906 29.8084C55.2964 29.4111 54.5574 29.1208 53.6737 28.9374ZM48.4858 37.0051V29.9917H50.4512C51.3197 29.9917 52.1044 30.0452 52.8053 30.1522C53.5061 30.2438 54.1004 30.4272 54.5879 30.7022C55.0907 30.962 55.4716 31.3287 55.7306 31.8024C56.0049 32.2608 56.142 32.8567 56.142 33.5901C56.142 34.2929 55.9973 34.8736 55.7078 35.332C55.4335 35.7903 55.0602 36.1571 54.5879 36.4321C54.1308 36.7071 53.5899 36.8981 52.9652 37.0051C52.3406 37.112 51.6854 37.1655 50.9998 37.1655C50.4208 37.1655 49.9256 37.1502 49.5142 37.1197C49.1181 37.0738 48.7752 37.0356 48.4858 37.0051Z' fill='#008F91'/>
                    <path fill-rule='evenodd' clip-rule='evenodd' d='M70.7531 36.1341C71.0121 36.8523 71.2863 37.601 71.5758 38.3802H73.2899C72.6652 36.73 72.0862 35.1944 71.553 33.7734C71.0197 32.3372 70.494 30.9849 69.976 29.7167C69.4732 28.4332 68.9704 27.2032 68.4676 26.0267C67.9648 24.8501 67.4315 23.6736 66.8678 22.4971H65.4965C64.9328 23.6736 64.3995 24.8501 63.8967 26.0267C63.3939 27.2032 62.8835 28.4332 62.3654 29.7167C61.8626 30.9849 61.3446 32.3372 60.8113 33.7734C60.278 35.1944 59.7067 36.73 59.0972 38.3802H60.7199C60.9942 37.601 61.2608 36.8523 61.5198 36.1341C61.7788 35.416 62.0378 34.7131 62.2969 34.0256H69.9988C70.2426 34.7131 70.494 35.416 70.7531 36.1341ZM64.4452 28.2957C64.9937 26.9358 65.5574 25.5988 66.1364 24.2848C66.7154 25.5988 67.2792 26.9358 67.8277 28.2957C68.3762 29.6556 68.9399 31.1224 69.5189 32.6962H62.7768C63.3558 31.1224 63.9119 29.6556 64.4452 28.2957Z' fill='#008F91'/>
                    <path d='M85.7142 22.4971H87.2683V38.3802H85.7142V30.7481H77.1209V38.3802H75.5668V22.4971H77.1209V29.3958H85.7142V22.4971Z' fill='#008F91'/>
                    <path d='M99.2986 36.0195C99.9537 36.7988 100.54 37.5857 101.058 38.3802H102.795C102.567 37.9524 102.27 37.4864 101.904 36.9822C101.554 36.4779 101.15 35.9584 100.693 35.4236C100.251 34.8889 99.7709 34.3617 99.2529 33.8422C98.7501 33.3074 98.232 32.8032 97.6987 32.3295C97.1807 31.8406 96.6627 31.3975 96.1446 31.0002C95.6418 30.5876 95.1695 30.2438 94.7277 29.9688C95.2762 29.4646 95.8932 28.884 96.5789 28.2269C97.2797 27.5546 97.9806 26.8747 98.6815 26.1871C99.3824 25.4995 100.045 24.8349 100.67 24.1931C101.295 23.5361 101.828 22.9707 102.27 22.4971H100.396C100.03 22.9249 99.5423 23.452 98.9329 24.0785C98.3234 24.705 97.6683 25.362 96.9674 26.0496C96.2818 26.7372 95.5809 27.4248 94.8648 28.1123C94.1639 28.7846 93.524 29.3805 92.945 29.9001V22.4971H91.3909V38.3802H92.945V30.5189C93.6306 30.9009 94.3391 31.3745 95.0705 31.9399C95.8171 32.5052 96.5484 33.1317 97.2645 33.8193C97.9806 34.5069 98.6586 35.2403 99.2986 36.0195Z' fill='#008F91'/>
                </svg>";
        }

    }
}