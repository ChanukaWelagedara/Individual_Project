   M S B A M L   `   `   `  ����K  GStudentManagemet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:StudentManagemetStudentManagemet  5   	   "    StudentManagemet.EditStudent   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:StudentManagemet     5   	     � Title$  
AddStudent��5   
   $	��700��6   $	��340��6*    � WindowStartupLocation$ CenterScreen=�5	   	    � AllowsTransparency$
 True��6.   
������  � WindowStyle$
 None=�5
   "    � DataContext 5      $   StudentManagemet.EditStudentVM  5   
   .��5      � .+�5   
   �� $��3q�6   
���   � �� Padding$ 20q�69   ���#243771._�5      �  � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $��50 �6$   �� 5      $	��150 �6$   �� 5      $��* �6$   �� 5      $
��Auto �6$   .+�5      �� $��1��6   $��EDIT STUDENT��6)      TextBoxText1#��[  6=   $	��150��6c   $��Bottom=�6o   $��Center=�6�   $��20(�6�   �� 5      $��2��6   $	��150��6H   $	��150��6T   $��UniformToFill=�6a   ��6%   �� *IsSelectedImage+6a   �� 5       $��3��6   ._�5!      � $��0,50,0,3q�6    � ColumnDefinitions 5"      �� 5#      $	��100 �6/   �� 5$      $	��13* �6/   �� 5%      $��2* �6/   �� 5&      $��* �6/    5(      �� 5)      $
��Auto �6,   �� 5*      $
��Auto �6,   �� 5+      $
��Auto �6,   �� 5,      $
��Auto �6,   �� 5-      $
��Auto �6,   �� 5.      $
��Auto �6,   �� 5/      $
��Auto �6,   �� 50      $
��Auto �6,   �� 51      $
��Auto �6,   �� 52      $
��Auto �6,   .+�56      �� $��0��6$   $��	Firt Name��61     TextBoxText#��[ 6B   �� 57        TextBoxBorder#��[ 6!   $��0��6H   $��1��6U   $��3��6e   ._�58      ��   TextBoxStyle1#��[ 6f   ��6&   �� *	Firstname+ �� UpdateSourceTrigger$ PropertyChanged=�6f   59      �� 5:      $��1��6$   $��	Last Name��61   #��[ 6B   �� 5;      #��[ 6!   $��1��6H   $��1��6U   $��3��6e   ._�5<      �� #��[ 6e   ��6&   �� *
Lastname+$ PropertyChanged=�6e   5=      �� 5>      $��2��6$   $	��Age��61   #��[ 6<   �� 5?      #��[ 6!   $��2��6H   $��1��6U   $��3��6e   ._�5@      �� #��[ 6`   ��6&   �� *Age+$ PropertyChanged=�6`   5A      �� 5B      $��3��6$   $��Date of Birth��61   #��[ 6F   �� 5C      #��[ 6!   $��3��6H   $��1��6U   $��3��6e   ._�5D      ��   TextBoxStyle#��[ 6C   ��6&   �� *Dateofbirth+6C   5F      �� 5H      $��4��6$   $	��GPA��61   #��[ 6<   �� 5I      #��[ 6!   $��4��6H   $��1��6U   $��3��6e   ._�5J      �� #��[ 6X   ��6&   �� *Gpa+$ Default=�6X   5K      �� 5L      $��5��6$   $��Gender��61   #��[ 6?   �� 5M      $��5��6%   $��1��62   $��3��6B   	 �� Orientation$	 
Horizontal=�6V   .+�5N      	� $��Center=�6*   $
��Male��6E   
 d� 	IsChecked
 6T   �� *IsMale+ �� Mode$ TwoWay=�	� 5O      $��Center=�6*   $��Female��6E   
 6V   �� *
IsFemale+$ TwoWay=�5Q      �� 5T      $��6��6$   $��District��61   #��[ 6A   �� 5U      #��[ 6!   $��6��6H   $��1��6U   $��3��6e   ._�5V      �� #��[ 6g   ��6&   �� *
Livingtown+$ PropertyChanged=�6g   5W      �� 5X      $��7��6$   $
��Imge��61   #��[ 6=   �� 5Y      $��
Edit Image��6!   $
��Left=�67   $��7��6z   $��1��6�     
ButtonOne1#��[ 6�   $��3��6�   $��5,3,0,8q�6�   $	��100��6�   $��40��6�   ��6R   �� *UploadPhotoCommand+6�   �� 5[      $��Edit Student��6!   #��[ 6_   $��9��6�   $��4��6�   ��68   �� *EditStudentCommand+6�   �� 5]      $��Cancel��6!   #��[ 6T   $��9��6|   $��2��6�   $��47,60,11,-13q�6�   ��62   �� *CancelCommand+6�   5`      5a      5b      5c      5d      5f      