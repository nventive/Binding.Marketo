using System;
using Foundation;
using UIKit;
using UserNotifications;

namespace Binding.Marketo.iOS
{
	// @interface MKTSecuritySignature : NSObject
	[BaseType(typeof(NSObject))]
	interface MKTSecuritySignature
	{
		// -(id)initWithAccessKey:(NSString *)accessKey signature:(NSString *)signature timestamp:(NSString *)timestamp email:(NSString *)email;
		[Export("initWithAccessKey:signature:timestamp:email:")]
		IntPtr Constructor(string accessKey, string signature, string timestamp, string email);

		// -(NSString *)getAccessKey;
		[Export("getAccessKey")]
		// [Verify(MethodToProperty)]
		string AccessKey { get; }

		// -(NSString *)getSignature;
		[Export("getSignature")]
		// [Verify(MethodToProperty)]
		string Signature { get; }

		// -(NSString *)getTimeStamp;
		[Export("getTimeStamp")]
		// [Verify(MethodToProperty)]
		string TimeStamp { get; }

		// -(NSString *)getEmail;
		[Export("getEmail")]
		// [Verify(MethodToProperty)]
		string Email { get; }

		// -(BOOL)isValid;
		[Export("isValid")]
		// [Verify(MethodToProperty)]
		bool IsValid { get; }
	}

	// @interface MarketoActionMetaData : NSObject
	[BaseType(typeof(NSObject))]
	interface MarketoActionMetaData
	{
		// -(void)setType:(NSString *)type;
		[Export("setType:")]
		void SetType(string type);

		// -(void)setDetails:(NSString *)details;
		[Export("setDetails:")]
		void SetDetails(string details);

		// -(void)setMetric:(NSNumber *)metric;
		[Export("setMetric:")]
		void SetMetric(NSNumber metric);

		// -(void)setLength:(NSNumber *)length;
		[Export("setLength:")]
		void SetLength(NSNumber length);

		// -(NSDictionary *)actionMetadata;
		[Export("actionMetadata")]
		// [Verify(MethodToProperty)]
		NSDictionary ActionMetadata { get; }
	}

	// @interface MarketoLead : NSObject
	[BaseType(typeof(NSObject))]
	interface MarketoLead
	{
		// -(void)setEmail:(NSString *)email;
		[Export("setEmail:")]
		void SetEmail(string email);

		// -(void)setGender:(NSString *)gender;
		[Export("setGender:")]
		void SetGender(string gender);

		// -(void)setFirstName:(NSString *)firstName;
		[Export("setFirstName:")]
		void SetFirstName(string firstName);

		// -(void)setLastName:(NSString *)lastName;
		[Export("setLastName:")]
		void SetLastName(string lastName);

		// -(void)setAddress:(NSString *)address;
		[Export("setAddress:")]
		void SetAddress(string address);

		// -(void)setCity:(NSString *)city;
		[Export("setCity:")]
		void SetCity(string city);

		// -(void)setState:(NSString *)state;
		[Export("setState:")]
		void SetState(string state);

		// -(void)setCountry:(NSString *)country;
		[Export("setCountry:")]
		void SetCountry(string country);

		// -(void)setPostalCode:(NSString *)postalCode;
		[Export("setPostalCode:")]
		void SetPostalCode(string postalCode);

		// -(void)setLeadSource:(NSString *)leadSource;
		[Export("setLeadSource:")]
		void SetLeadSource(string leadSource);

		// -(void)setFacebookId:(NSString *)facebookId;
		[Export("setFacebookId:")]
		void SetFacebookId(string facebookId);

		// -(void)setTwitterId:(NSString *)twitterId;
		[Export("setTwitterId:")]
		void SetTwitterId(string twitterId);

		// -(void)setLinkedInId:(NSString *)LinkedInId;
		[Export("setLinkedInId:")]
		void SetLinkedInId(string LinkedInId);

		// -(void)setBirthDay:(NSString *)birthday;
		[Export("setBirthDay:")]
		void SetBirthDay(string birthday);

		// -(void)setFacebookProfileURL:(NSString *)url;
		[Export("setFacebookProfileURL:")]
		void SetFacebookProfileURL(string url);

		// -(void)setFacebookProfilePicURL:(NSString *)url;
		[Export("setFacebookProfilePicURL:")]
		void SetFacebookProfilePicURL(string url);

		// -(void)setFieldName:(NSString *)name withValue:(NSString *)value;
		[Export("setFieldName:withValue:")]
		void SetFieldName(string name, string value);

		// -(NSDictionary *)userData;
		[Export("userData")]
		// [Verify(MethodToProperty)]
		NSDictionary UserData { get; }
	}

	// @interface Marketo : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface Marketo
	{
		// @property (readonly, nonatomic) NSString * appSecret;
		[Export("appSecret")]
		string AppSecret { get; }

		// +(Marketo *)sharedInstance;
		[Static]
		[Export("sharedInstance")]
		// [Verify(MethodToProperty)]
		Marketo SharedInstance { get; }

		// -(void)initializeWithMunchkinID:(NSString *)munchkinID appSecret:(NSString *)appSecret launchOptions:(NSDictionary *)launchOptions;
		[Export("initializeWithMunchkinID:appSecret:launchOptions:")]
		void InitializeWithMunchkinID(string munchkinID, string appSecret, NSDictionary launchOptions);

		// -(void)setTimeoutInterval:(NSInteger)seconds;
		[Export("setTimeoutInterval:")]
		void SetTimeoutInterval(nint seconds);

		// -(void)reportAction:(NSString *)actionName withMetaData:(MarketoActionMetaData *)metaData;
		[Export("reportAction:withMetaData:")]
		void ReportAction(string actionName, MarketoActionMetaData metaData);

		// -(void)associateLead:(MarketoLead *)lead;
		[Export("associateLead:")]
		void AssociateLead(MarketoLead lead);

		// -(void)registerPushDeviceToken:(NSData *)deviceToken;
		[Export("registerPushDeviceToken:")]
		void RegisterPushDeviceToken(NSData deviceToken);

		// -(void)unregisterPushDeviceToken;
		[Export("unregisterPushDeviceToken")]
		void UnregisterPushDeviceToken();

		// -(void)trackPushNotification:(NSDictionary *)userInfo;
		[Export("trackPushNotification:")]
		void TrackPushNotification(NSDictionary userInfo);

		// -(void)handlePushNotification:(NSDictionary *)userInfo;
		[Export("handlePushNotification:")]
		void HandlePushNotification(NSDictionary userInfo);

		// -(BOOL)isPushRegistered;
		[Export("isPushRegistered")]
		// [Verify(MethodToProperty)]
		bool IsPushRegistered { get; }

		// -(BOOL)application:(UIApplication *)application openURL:(NSURL *)url sourceApplication:(NSString *)sourceApplication annotation:(id)annotation;
		[Export("application:openURL:sourceApplication:annotation:")]
		bool Application(UIApplication application, NSUrl url, string sourceApplication, NSObject annotation);

		// -(void)application:(UIApplication *)application didReceiveLocalNotification:(UILocalNotification *)notification;
		[Export("application:didReceiveLocalNotification:")]
		void Application(UIApplication application, UILocalNotification notification);

		// -(void)userNotificationCenter:(UNUserNotificationCenter *)center didReceiveNotificationResponse:(UNNotificationResponse *)response withCompletionHandler:(void (^)())completionHandler;
		[Export("userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:")]
		void UserNotificationCenter(UNUserNotificationCenter center, UNNotificationResponse response, Action completionHandler);

		// -(void)setSecureSignature:(MKTSecuritySignature *)conf;
		[Export("setSecureSignature:")]
		void SetSecureSignature(MKTSecuritySignature conf);

		// -(void)removeSecureSignature;
		[Export("removeSecureSignature")]
		void RemoveSecureSignature();

		// -(BOOL)isSecureModeEnabled;
		[Export("isSecureModeEnabled")]
		// [Verify(MethodToProperty)]
		bool IsSecureModeEnabled { get; }

		// -(NSString *)getDeviceId;
		[Export("getDeviceId")]
		// [Verify(MethodToProperty)]
		string DeviceId { get; }

		// -(void)reportAll;
		[Export("reportAll")]
		void ReportAll();
	}
}

