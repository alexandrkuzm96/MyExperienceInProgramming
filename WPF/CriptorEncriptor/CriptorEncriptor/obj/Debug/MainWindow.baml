   M S B A M L   `   `   `  ����K  GCriptorEncriptor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CriptorEncriptorCriptorEncriptor  5   	   !    CriptorEncriptor.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:CriptorEncriptor     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)      WindowStyle#��[  5	   	   .��5
      �  � RowDefinitions 5   
   �� 5      $
��25px �6   �� 5      �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   � .+�5   
   	� -   5         	�Name$ Caesar��5      $��Шифр цезаря��6&    d� 	IsChecked$ FalseY�5       	� 	GroupName$ 	CriptType��6%     
RadioStyle#��[ 5      	� 5   
   -   5        $ Vigener��5      $��Шифр Виженера��6'   #��[ 5      $ FalseY�5      $ 	CriptType��6(   5      ]� 5   
   $��1��6   .+�5      �� $��шаг��6     
LabelStyle#��[ 6"   �� 5      -   5         ��Name$
 step��5      $��0��6$   $��50��6-   68   �� 5      $!��ключевое слово��6   #��[ 6-   �� 5       -   5        $ keyWord��5       5!      �� 5"   
   $��1��6   .+�5#      �� $!��Исходный текст��6     TextBlockStyle#��[ 6.   �� 5$      -   5        $ 
SourceText��5$        TextBoxStyle#��[ 5%      5&      �� 5'   
   $��1��6   $��1��6"   .+�5(      �� $!��Итоговый текст��6   #��[ 6.   �� 5)      -   5        $ ConvertedText��5)      #��[ 5*      5+      � 5,   
   $��2��6   $��2��6!   .+�5-      �� -   5        $��Открыть файл��5-        ButtonStyle#��[ 5.      �� 5/      -   5        $!��Сохранить файл��5/      #��[ 50      �� 51      -	   5        $��Защифровать��51      #��[ 52      �� 53      -
   5        $��Расшифровать��53      #��[ 54      55      56      57      