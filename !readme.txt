////////////////////////////////////////////////////////////////////////////////////////////////
��������� �����
////////////////////////////////////////////////////////////////////////////////////////////////
ConsoleMedDetect - ���������� ���������� C# ��� ������ � �������������
FuncMedDetect - ����������������� ������ ���������� ��� ������ � �������������
func_med_detect.m - �������� ��� ���������� �� ����� m-������ Matlab
test_func.m = ������� ������ ���������� Matlab
lc_input.tif - ������ �������� �����
Ic_out.png - ������ ��������� �����

////////////////////////////////////////////////////////////////////////////////////////////////
������ ���������� ������ ����������� ����������
////////////////////////////////////////////////////////////////////////////////////////////////
ConsoleMedDetect.exe factor1 factor2 threshold1 threshold2 folder file
factor1 - ����������� ����������� ��� ��������� ��������
factor2 - ����������� ����������� ��� ���������� ��������
threshold1 - �������� ������� �������� ������� ��������
threshold2 - �������� ������� �������� ������� ��������
folder - ��� ����� � �������������
file - ��� ����� �����������

������ ������:
ConsoleMedDetect.exe 0.8 0.8 0 0.25 "D:\\Projects\\MED\\Matlab\\SourceCode\\" "lc_input.tif"
////////////////////////////////////////////////////////////////////////////////////////////////

////////////////////////////////////////////////////////////////////////////////////////////////
��������� ������� func_med_detect
////////////////////////////////////////////////////////////////////////////////////////////////
������� func_med_detect.m ������������� ��� ��������������� ���������� �������� �� �����������,
� ����� ��������� ����� ���� �������, ����� �������, ��������� ������ �������� �������� �������.

������� ��������� :
path			|  ���� � ����� ��������� �����������;
filename		|  ��� ����� �����. �����������;
threshold		|  ������ �� ���� ��������� [a b],
				|  ��� � - ���������, b - �������� �������� ��������� ������� ���������� ��������
				|  a � b ����� ��������� �������� � ���������� [0 1]; 

����������� �������� ��� ���������� ������� ���������������� ��� �����������   
������ �������� �������� BW = edge(I,'Sobel',threshold * fudgeFactor):
fudgeFactor1	|  ��� �������� ��������
fudgeFactor2	|  ��� ���������� ��������

�������� ��������� �������:
result			|  ������ 2x2, ���
				|  ������� 1 - ��������� ��� ���� ��������� ��������
				|  ������� 2 - ��������� ��� ������ ���������� ��������
				|  ������ 1 - ����������
				|  ������ 2 - ��������� (����� �������)
Ic_final		|  �������� ����������� � ������������ ��������� �
				|  ���������� ���������� ��������

�������� ����������� Ic_final ����� ������������� ����������� �� ���� � ���� Ic_out.png

�������� ������� ���������� ��� ������ ����������� � �����
	threshold = [0 .25];
	fudgeFactor1 = 0.8;
	fudgeFactor2 = 0.8;