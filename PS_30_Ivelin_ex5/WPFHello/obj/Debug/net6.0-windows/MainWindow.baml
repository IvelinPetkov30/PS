   M S B A M L   `   `   `  ����C  ?WPFHello, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WPFHelloWPFHello  5   	       WPFHello.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WPFHello     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � -   5         �Name$ gridgrid��5	      .+�5
   
   �� -   5         ��Name$ Hi��5
      $��Hello, WPF!��6   $
��Left=�62   $	��Top=�6M   $��99��6e   $	��390��6q   $��48(�6}   $��	Castellar)�6�   $��	10,10,0,0q�6�   �� 5   
   -   5         ��Name$ btnHello��5      $��H!��6#   $
��Left=�60   $��	315,0,0,0q�6K   $��Center=�6^   $��54��6�   �� 5   
   -   5        $ lblName��5      $��Name:��6!   $
��Left=�61   $��	15,85,0,0q�6L   $	��Top=�6_   $��25��6w   �� 5   
   -   5         ��Name$ txtName��5      $
��Left=�6#   $��	97,91,0,0q�6>    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6e   $	��120��6}   $��20��6�   �� 5   
   -   5        $ txtName1��5      $
��Left=�6$   $��
97,119,0,0q�6?   $
 Wrap=�6S   $	��Top=�6g   $	��120��6   $��20��6�   �� 5   
   -   5        $ txtName2��5      $
��Left=�6$   $��
97,150,0,0q�6?   $
 Wrap=�6S   $	��Top=�6g   $	��120��6   $��20��6�   �� 5   
   -   5        $ lblName1��5      $��Name:��6"   $
��Left=�62   $��
15,116,0,0q�6M   $	��Top=�6a   $��25��6y   �� 5   
   -	   5        $ lblName2��5      $��Name:��6"   $
��Left=�62   $��
15,146,0,0q�6M   $	��Top=�6a   $��25��6y   �� 5   
   -
   5         ��Name$ gbUser��5      $�� ��6#   $��-2,-2,397,170q�6-    J� RenderTransformOrigin$ 0.5,0.5&�6D   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.192Q�6&   T� 5      5      5      �� 5   
   -   5        	 ��Name$	 peopleListBox��5      $��595,102,112,203q�6)   $
 �� IsSynchronizedWithCurrentItem$

 TrueY�6t   .@�5      �� $
��Mike��6   �� 5       $
��Lisa��6   �� 5!      $
��John��6   �� 5"      $
��Mary��6   5#      �� 5$   
   -   5        $ BtnGreet��5$      $��Greeting��6#   $
��Left=�66   $��595,291,0,0q�6Q   $	��Top=�6f   $��93��6~   $��20��6�   6�   5&      5'      