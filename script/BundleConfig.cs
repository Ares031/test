using System.Web.Optimization;

namespace InsuranceWeb
{
	public class BundleConfig
	{
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			// 首頁 javascript & css
			bundles.Add(new ScriptBundle("~/bundles/IndexJS").Include(
                //"~/Scripts/Home/swiper.jquery.3.4.0.min.js",
                "~/Scripts/Home/swiper.min.js",
                "~/Scripts/Home/Index.js",
				"~/Scripts/Account/LogInPart.js",
				"~/Scripts/Home/autoskip.js",
				"~/Scripts/Home/insurencefee.js",
				"~/Scripts/Home/commons.js",
				"~/Scripts/FacebookPixelJS/FBPJS.js",
				"~/Scripts/DialogScript.js",
				"~/Scripts/jquery-ui.min.js",
				"~/Scripts/Home/jquery.textslider.min.js",
				"~/Scripts/Home/owl.carousel.js",
				"~/Scripts/easydropdown/jquery.easydropdown.js"
			));

			bundles.Add(new StyleBundle("~/Content/jq-ui-dialog").Include(
				"~/Content/jquery-ui.css",
				"~/Content/jquery.ui.dialog.css"
            ));

			bundles.Add(new ScriptBundle("~/bundles/global").Include(
				"~/Scripts/global-popup-modal.js"
			));
            bundles.Add(new StyleBundle("~/Content/Global/popup").Include(
				"~/Content/2016/global-popup.css"
			));

			bundles.Add(new StyleBundle("~/Content/Index/css").Include(
				"~/Content/2016/css.css",
				"~/Content/2016/index.swiper.css",
				"~/Content/2016/cssbyh.css",
				"~/Content/2016/prod-sheets.css",
				"~/Content/2016/index.css",
				"~/Content/2016/promo.css",
				"~/Content/2016/estimate.css",
				"~/Content/2016/home-insurance.css",
                "~/Content/2016/product-carousel.css",
                "~/Content/easydropdown/easydropdown.css",
                "~/Content/"
			));

			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
				"~/Scripts/jquery-1.10.2.js"
				, "~/Scripts/jquery.blockUI.js"
				, "~/Scripts/jquery.form.js"
				, "~/Scripts/serialize-json.jquery.js"
				, "~/Scripts/GlobalScript.js"
				, "~/Scripts/jquery.cookie.js"
				, "~/Scripts/swiper.min.js"
				, "~/Scripts/jquery.preload.js"
				, "~/Scripts/jquery.zoom.min.js"
				, "~/Scripts/placeholders.min.js"
				//, "~/Scripts/idangerous.swiper.min.js"
				//, "~/Scripts/jquery.easing.1.3.js"
				//, "~/Scripts/jquery.multiscroll.min.js"
                , "~/Scripts/FacebookPixelJS/FBPJS.js"
				, "~/Scripts/SE_NeuroTracking.js"));

			bundles.Add(new ScriptBundle("~/bundles/jquery_prodintro").Include(
				"~/Scripts/jquery-1.10.2.js"
				, "~/Scripts/jquery.blockUI.js"
				, "~/Scripts/jquery.form.js"
				, "~/Scripts/serialize-json.jquery.js"
				, "~/Scripts/GlobalScript.js"
				, "~/Scripts/jquery.cookie.js"
				//, "~/Scripts/swiper.min.js"
				, "~/Scripts/jquery.preload.js"
				, "~/Scripts/jquery.zoom.min.js"
				, "~/Scripts/idangerous.swiper.min.js"
				, "~/Scripts/jquery.easing.1.3.js"
				, "~/Scripts/jquery.multiscroll.min.js"
				//, "~/Scripts/placeholders.min.js"		
                , "~/Scripts/FacebookPixelJS/FBPJS.js"
				, "~/Scripts/SE_NeuroTracking.js"));

			bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
				"~/Scripts/jquery.validate*"));

			bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
				"~/Scripts/JqueryUI/jquery.ui.core.js"
				, "~/Scripts/JqueryUI/jquery.ui.widget.js"
				, "~/Scripts/JqueryUI/jquery.ui.position.js"
				, "~/Scripts/JqueryUI/jquery.ui.mouse.js"
				, "~/Scripts/JqueryUI/jquery.ui.draggable.js"
				, "~/Scripts/JqueryUI/jquery.ui.resizable.js"
				, "~/Scripts/JqueryUI/jquery.ui.button.js"
				, "~/Scripts/JqueryUI/jquery.ui.datepicker.js"
				, "~/Scripts/JqueryUI/i18n/jquery.ui.datepicker-zh-TW.js"
				, "~/Scripts/JqueryUI/jquery.ui.dialog.js"
				, "~/Scripts/JqueryUI/jquery.ui.slider.js"
				, "~/Scripts/JqueryUI/jquery.ui.touch-punch.js"));

			bundles.Add(new ScriptBundle("~/bundles/jqueryui2").Include(
				"~/Scripts/jquery-ui.min.js"));

			bundles.Add(new ScriptBundle("~/bundles/jquerydialog").Include(
				"~/Scripts/DialogScript.js"));

			bundles.Add(new ScriptBundle("~/bundles/jquerywizard").Include(
				"~/Scripts/jquery.psteps.js"));

			bundles.Add(new ScriptBundle("~/bundles/modifyemail").Include(
				"~/Scripts/ModifyEmail.js"));

			bundles.Add(new ScriptBundle("~/bundles/forgetpwd").Include(
				"~/Scripts/CustomerJS/ForgetPwdJS.js"));

			bundles.Add(new ScriptBundle("~/bundles/resendmail").Include(
				"~/Scripts/CustomerJS/ReSendMailJS.js"));

			bundles.Add(new ScriptBundle("~/bundles/printjs").Include(
				"~/Scripts/printThis.js"));

			bundles.Add(new ScriptBundle("~/bundles/loginjs").Include(
				"~/Scripts/CustomerJS/Login.js"
                ));

			#region 付款Javascript
			bundles.Add(new ScriptBundle("~/bundles/PaymentCreditCard").Include(
				"~/Scripts/PaymentCreditCard.js"));

			bundles.Add(new ScriptBundle("~/bundles/PaymenteBill").Include(
				"~/Scripts/PaymenteBill.js"));
			#endregion

			#region 驗證Javascript
			bundles.Add(new ScriptBundle("~/bundles/VerifyOTP").Include(
				"~/Scripts/VerifyOTP.js",
				"~/Scripts/jquery.countdown.js"));

			bundles.Add(new ScriptBundle("~/bundles/VerifyCertificate").Include(
				"~/Scripts/VerifyCertificate.js"));

			//雲端憑證 Javascript
			bundles.Add(new ScriptBundle("~/bundles/VerifyPKI").Include(
				"~/Scripts/pkiJS.js"));
			bundles.Add(new ScriptBundle("~/bundles/VerifyPKIReg").Include(
				"~/Scripts/pkiRules.js",
				"~/Scripts/pkiJS.js"));
			#endregion

			#region 地址
			bundles.Add(new ScriptBundle("~/bundles/TaiwanZipCode").Include(
				"~/Scripts/TaiwanZipCode.js"));

			bundles.Add(new ScriptBundle("~/bundles/TaiwanDate").Include(
				"~/Scripts/TaiwanDate.js"));
			#endregion

			#region 旅平險保險
			bundles.Add(new ScriptBundle("~/bundles/TravelCalcJS").Include(
				"~/Scripts/Travel/TravelCalc.js"));

			bundles.Add(new ScriptBundle("~/bundles/TravelJS").Include(
				"~/Scripts/Travel/MainTravelData.js"));

			bundles.Add(new ScriptBundle("~/bundles/TravelMainStep").Include(
				"~/Scripts/Travel/MainStep.js"));

			bundles.Add(new ScriptBundle("~/bundles/TravelStep1").Include(
				"~/Scripts/Travel/TravelStep1.js"));

			bundles.Add(new ScriptBundle("~/bundles/TravelStep2").Include(
				"~/Scripts/Travel/TravelStep2.js",
				"~/Scripts/Insurance/BirthdayPresent.js",
				"~/Scripts/Insurance/Salesperson.js",
				"~/Scripts/Insurance/IdNumber.js"));

			bundles.Add(new ScriptBundle("~/bundles/TravelStep3").Include(
				"~/Scripts/Travel/TravelStep3.js"));

			bundles.Add(new ScriptBundle("~/bundles/TravelStep4").Include(
				"~/Scripts/Travel/TravelStep4.js"));

			bundles.Add(new ScriptBundle("~/bundles/TravelStep5").Include(
				"~/Scripts/Travel/TravelStep5.js"));
			#endregion

			#region 意外傷害險
			bundles.Add(new ScriptBundle("~/bundles/AccidentCalcJS").Include(
				"~/Scripts/Accident/AccidentCalc.js"));

			bundles.Add(new ScriptBundle("~/bundles/AccidentMainStep").Include(
				"~/Scripts/Accident/MainStep.js"));

			bundles.Add(new ScriptBundle("~/bundles/AccidentStep1").Include(
				"~/Scripts/Accident/AccidentStep1.js"));

			bundles.Add(new ScriptBundle("~/bundles/AccidentStep2").Include(
				"~/Scripts/Accident/AccidentStep2.js"));

			bundles.Add(new ScriptBundle("~/bundles/AccidentStep3").Include(
				"~/Scripts/Accident/AccidentStep3.js"));

			bundles.Add(new ScriptBundle("~/bundles/AccidentStep3New").Include(
				"~/Scripts/Accident/AccidentStep3New.js",
				"~/Scripts/Insurance/BirthdayPresent.js",
				"~/Scripts/Insurance/Salesperson.js",
				"~/Scripts/Insurance/IdNumber.js"));

			bundles.Add(new ScriptBundle("~/bundles/AccidentStep3Life").Include(
				"~/Scripts/Accident/AccidentStep3Life.js",
				"~/Scripts/Insurance/BirthdayPresent.js",
				"~/Scripts/Insurance/Salesperson.js",
				"~/Scripts/Insurance/IdNumber.js"));

			bundles.Add(new ScriptBundle("~/bundles/AccidentStep3Health").Include(
				"~/Scripts/Accident/AccidentStep3Health.js",
				"~/Scripts/Insurance/BirthdayPresent.js",
				"~/Scripts/Insurance/Salesperson.js",
				"~/Scripts/Insurance/IdNumber.js"));

			bundles.Add(new ScriptBundle("~/bundles/AccidentStep4").Include(
				"~/Scripts/Accident/AccidentStep4.js"));

			bundles.Add(new ScriptBundle("~/bundles/AccidentStep5").Include(
				"~/Scripts/Accident/AccidentStep5.js"));

			bundles.Add(new ScriptBundle("~/bundles/AccidentComplete").Include(
				"~/Scripts/Accident/AccidentComplete.js"));

			bundles.Add(new ScriptBundle("~/bundles/AccidentStep3Annuity").Include(
				"~/Scripts/Accident/AccidentStep3Annuity.js",
				"~/Scripts/Insurance/BirthdayPresent.js",
				"~/Scripts/Insurance/Salesperson.js",
				"~/Scripts/Insurance/IdNumber.js"));

			bundles.Add(new ScriptBundle("~/bundles/AccidentStep3SevenPlus").Include(
				"~/Scripts/Accident/AccidentStep3SevenPlus.js",
				"~/Scripts/Insurance/BirthdayPresent.js",
				"~/Scripts/Insurance/Salesperson.js",
				"~/Scripts/Insurance/IdNumber.js"));

			bundles.Add(new ScriptBundle("~/bundles/AccidentStep3UpCash").Include(
				"~/Scripts/Accident/AccidentStep3UpCash.js",
				"~/Scripts/Insurance/BirthdayPresent.js",
				"~/Scripts/Insurance/Salesperson.js",
				"~/Scripts/Insurance/IdNumber.js"));

			bundles.Add(new ScriptBundle("~/bundles/auto-complete").Include(
				"~/Scripts/JqueryUI/jquery.ui.menu.js",
				"~/Scripts/JqueryUI/jquery.ui.autocomplete.js"));
			bundles.Add(new StyleBundle("~/bundles/ins-auto-complete").Include(
				"~/Content/jquery.ui.autocomplete.css",
				"~/Content/Insurance/ins-auto-complete.css"));
			#endregion

			#region 廣告輪播
			bundles.Add(new ScriptBundle("~/bundles/slick").Include(
				"~/Scripts/responsiveslides.js"));

			bundles.Add(new StyleBundle("~/Content/slick").Include(
				"~/Content/responsiveslides.css"));
			#endregion

			#region 首頁
			bundles.Add(new ScriptBundle("~/bundles/index").Include(
				"~/Scripts/jquery-ui.min.js"));

			bundles.Add(new StyleBundle("~/Content/index").Include(
				"~/Content/jquery_ui_hm.css"));
			#endregion

			// 選單
			bundles.Add(new ScriptBundle("~/bundles/Menu1").Include(
				"~/Scripts/Menu/Menu1.js"));

			#region 會員註冊
			bundles.Add(new ScriptBundle("~/bundles/MemberRegister").Include(
				"~/Scripts/Register/MemberRegister.js"));

			bundles.Add(new ScriptBundle("~/bundles/MemberRegisterStep1").Include(
				"~/Scripts/Register/Step1.js"));

			bundles.Add(new ScriptBundle("~/bundles/MemberRegisterStep2").Include(
				"~/Scripts/Register/Step2.js"));

			bundles.Add(new ScriptBundle("~/bundles/MemberRegisterStep2New").Include(
				"~/Scripts/Register/Step2New.js"));

			bundles.Add(new ScriptBundle("~/bundles/MemberRegisterStep2Policy").Include(
				"~/Scripts/Register/Step2Policy.js"));

			bundles.Add(new ScriptBundle("~/bundles/MemberRegisterStep3").Include(
				"~/Scripts/Register/Step3.js"));

			bundles.Add(new ScriptBundle("~/bundles/MemberRegisterStep3New").Include(
				"~/Scripts/Register/Step3New.js"));

			bundles.Add(new ScriptBundle("~/bundles/MemberRegisterStep4").Include(
				"~/Scripts/Register/Step4.js"));

			bundles.Add(new StyleBundle("~/Content/MemberRegister").Include(
				"~/Content/MemberRegister.css"));
			#endregion
            
			#region 會員驗證OTP
			bundles.Add(new ScriptBundle("~/bundles/PolicyMobile1").Include(
				"~/Scripts/CustomerJS/PolicyMobileJS.js"));

			bundles.Add(new ScriptBundle("~/bundles/PolicyMobile2").Include(
				"~/Scripts/CustomerJS/PolicyWhiteMobileJS.js"));
			#endregion

			// 使用開發版本的 Modernizr 進行開發並學習。然後，當您
			// 準備好實際執行時，請使用 http://modernizr.com 上的建置工具，只選擇您需要的測試。
			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
				"~/Scripts/modernizr-*"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
				"~/Scripts/bootstrap.js",
				"~/Scripts/respond.js"));

			bundles.Add(new StyleBundle("~/Content/bootstrapcss").Include(
				//"~/Content/bootstrap.css"
				"~/Content/sty.css"));

			bundles.Add(new StyleBundle("~/Content/css").Include(
				"~/Content/sty.css",
				"~/Content/swiper.min.css",
				//"~/Content/style.min.css",
				//"~/Content/Site.css",
				//"~/Content/website.css",
				//"~/Content/PageTable.css",
				//"~/Content/idangerous.swiper.css",
				//"~/Content/jquery.multiscroll.css",
				"~/Content/font-awesome.min.css"));

			bundles.Add(new StyleBundle("~/Content/main_css").Include(
				"~/Content/sty.css"));

			bundles.Add(new StyleBundle("~/Content/css_prodintro").Include(
				"~/Content/sty.css",
				"~/Content/idangerous.swiper.css",
				"~/Content/jquery.multiscroll.css",
				//"~/Content/style.min.css",
				//"~/Content/swiper.min.css",
				//"~/Content/Site.css",
				//"~/Content/website.css",
				//"~/Content/PageTable.css",
				"~/Content/font-awesome.min.css"));

			bundles.Add(new StyleBundle("~/Content/css_LM").Include(
				"~/Content/website.css",
				"~/Content/LayoutMember.css",
				"~/Content/PageTable.css"));

			bundles.Add(new StyleBundle("~/Content/jqueryuicss").Include(
				"~/Content/jquery.ui.core.css",
				"~/Content/jquery.ui.resizable.css",
				"~/Content/jquery.ui.button.css",
				"~/Content/jquery.ui.dialog.css",
				"~/Content/jquery.ui.datepicker.css",
				"~/Content/jquery.ui.theme.css",
				"~/Content/jquery.ui.slider.css"));

			bundles.Add(new StyleBundle("~/Content/jqueryuicss2").Include(
				"~/Content/jquery-ui.css",
				"~/Content/jquery.ui.dialog.css"));

			bundles.Add(new StyleBundle("~/Content/jquerywizardcss").Include(
				"~/Content/devnote.css"));

			bundles.Add(new StyleBundle("~/Content/travelcss").Include(
				"~/Content/sty.css",
				"~/Content/Insurance/birthday-present.css"
				//"~/Content/TravelCSS.css"
			));

			bundles.Add(new StyleBundle("~/Content/PicMerger/merger").Include(
				"~/Content/PicMerger/PicMerger.css"));

			#region 首頁中間商品左右滑的CSS+JS
			bundles.Add(new StyleBundle("~/Content/HomeCSS").Include(
				"~/Content/HomeMidMenu.css"));

			bundles.Add(new ScriptBundle("~/bundles/HomeJS").Include(
				"~/Scripts/HomeJS.js"));
			#endregion

			// Layout Menu scripts
			bundles.Add(new ScriptBundle("~/bundles/LayoutMenu").Include(
				"~/Scripts/Account/LogInPart.js",
				"~/Scripts/right_top_menu.js"));

			bundles.Add(new StyleBundle("~/Content/css/ProductIntro").Include(
				"~/Content/2016/css.css",
				"~/Content/2016/prod-intro.css",
				"~/Content/2016/cssbyh.css",
				"~/Content/2016/prod-sheets.css",
				"~/Content/2016/estimate.css"));
			bundles.Add(new ScriptBundle("~/bundles/ProductIntro").Include(
				"~/Scripts/Introduction/main.js",
				"~/Scripts/Introduction/autoskip.js",
				"~/Scripts/Introduction/swiper.2.7.6.js",
				"~/Scripts/Home/commons.js",
				"~/Scripts/DialogScript.js",
				"~/Scripts/Introduction/jquery.backtop.js",
				"~/Scripts/Home/insurencefee.js",
				"~/Scripts/jquery-ui.min.js",
				"~/Scripts/easydropdown/jquery.easydropdown.js"));

			bundles.Add(new StyleBundle("~/Content/css/BankList").Include(
				"~/Content/2016/bank-list.css"
			));

			bundles.Add(new ScriptBundle("~/bundles/estimate-ez").Include(
				"~/Scripts/Home/EstimationAnnuity.js"
			));

			bundles.Add(new ScriptBundle("~/bundles/estimate-upcash").Include(
				"~/Scripts/Home/EstimationUpCash.js"
			));

			bundles.Add(new ScriptBundle("~/bundles/ga").Include(
				"~/Scripts/GoogleAnalyt/GACommons.js"
			));

			bundles.Add(new StyleBundle("~/css/hmenu").Include(
				"~/Content/2016/hmenu.css"
			));

			bundles.Add(new StyleBundle("~/css/original").Include(
				"~/Content/2016/Member/css.css",
				"~/Content/2016/Member/newbox.css"
            ));

			BundleTable.EnableOptimizations = true;
		}
	}
}
