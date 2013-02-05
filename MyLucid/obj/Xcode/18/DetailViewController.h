// WARNING
// This file has been generated automatically by MonoDevelop to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <UIKit/UIKit.h>
#import <MapKit/MapKit.h>
#import <Foundation/Foundation.h>
#import <CoreGraphics/CoreGraphics.h>


@interface DetailViewController : UIViewController {
	UIBarButtonItem *_cancelComposeEmailButton;
	UITextField *_toTextField;
	UITextField *_subjectTextField;
	UITextView *_bodyTextView;
	UIBarButtonItem *_insertVideoButton;
	UIBarButtonItem *_insertImageButton;
	UIBarButtonItem *_insertTakePictureButton;
}

@property (nonatomic, retain) IBOutlet UIBarButtonItem *cancelComposeEmailButton;

@property (nonatomic, retain) IBOutlet UITextField *toTextField;

@property (nonatomic, retain) IBOutlet UITextField *subjectTextField;

@property (nonatomic, retain) IBOutlet UITextView *bodyTextView;

@property (nonatomic, retain) IBOutlet UIBarButtonItem *insertVideoButton;

@property (nonatomic, retain) IBOutlet UIBarButtonItem *insertImageButton;

@property (nonatomic, retain) IBOutlet UIBarButtonItem *insertTakePictureButton;

@end
