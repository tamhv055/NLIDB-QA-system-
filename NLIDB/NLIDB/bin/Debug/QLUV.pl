s(SEM)-->vp(SEM).
vp(VB)-->vb(VB).
vp(SEM)-->rb(RB),vp(VP),{append(RB,VP,SEM)}.
vp(SEM)-->vb(VB),np(NP),{append(VB,NP,SEM)}.
vp(SEM)-->vb(VB),np(NP),adjp(ADJP),{append(VB,NP,T1),append(T1,ADJP,SEM)}.
vp(SEM)-->vb(VB),sbar(SBAR),{append(VB,SBAR,SEM)}.
np(SEM)-->nn(NN),pp(PP),{append(NN,PP,SEM)}.
np(SEM)-->nn(SEM).
np(SEM)-->cd(SEM).
np(SEM)-->nn(NN),np(NP),{append(NN,NP,SEM)}.
np(SEM)-->nn(NN),cc(CC),np(NP),{append(NN,CC,T1),append(T1,NP,SEM)}.
np(SEM)-->cd(CD),cc(CC),np(NP),{append(CD,CC,T1),append(T1,NP,SEM)}.
np(SEM)-->nn(NN),np(NP1),cc(CC),np(NP2),{append(NN,NP1,T1),append(T1,CC,T2),append(T2,NP2,SEM)}.
pp(SEM)-->in(IN),np(NP),{append(IN,NP,SEM)}.
pp(SEM)-->in(IN),np(NP),pp(PP),{append(IN,NP,T1),append(T1,PP,SEM)}.
sbar(SEM)-->np(NP),vp(VP),{append(NP,VP,SEM)}.
sbar(SEM)-->np(NP),vp(VP),cc(CC),sbar(SBAR),{append(NP,VP,T1),append(T1,CC,T2),append(T2,SBAR,SEM)}.
adjp(SEM)-->jj(SEM).
vb("Where ")-->[có];[được];[muốn];[sinh].
vb("Select ")-->[liệt,kê];[cho,biết];[hãy,cho,biết].
vb("> ")-->[lớn,hơn];[trên].
vb("< ")-->[nhỏ,hơn];[dưới].
vb("= ")-->[là];[bằng];[ở].
vb(">= ")-->[lớn,hơn,hoặc,bằng].
vb("<= ")-->[bé,hơn,hoặc,bằng].
vb(" like ") -->[thuộc].
nn("Hoten ")-->[tên];[họ,và,tên];[họ,tên].
nn("UngVien ")--> [ứng,viên];[các,ứng,viên];[những, người];[người].
nn("year(ngaysinh) ")--> [năm,sinh].
nn("month(ngaysinh)  ")--> [tháng,sinh].
nn("month(ngaysinh) = ")--> [tháng].
nn("year(ngaysinh) = ")--> [năm].
nn(" ngaysinh = ")-->[sinh,ngày];[sinh,vào].
nn(" Gioitinh ") -->[giới,tính].
nn(" Diachi ")-->[địa,chỉ].
nn(" diachi= ") -->[đang,ở].
nn(" ngaysinh ")-->[ngày,sinh].
nn(" vitriungtuyen ")-->[vị,trí,ứng,tuyển].
nn(" count(*) ")-->[số,lượng].
nn(" vitriungtuyen= ") -->[ứng,tuyển,vị,trí].
nn(" trinhdo ")-->[trình,độ];[học,vấn].
nn(" luongtoithieu ")-->[lương,yêu,cầu];[lương,tối,thiểu];[lương].
nn(" phuongtiendichuyen ") -->[phương,tiện,di,chuyển];[xe]. 
nn("DATEDIFF(year,Ngaysinh,GETDATE()) ") -->[số,tuổi];[tuổi].
nn("N'NV Giao Nhận'") -->[nhân,viên,giao,nhận].
nn("N'CTV Giao nhận'") -->[cộng,tác,viên,giao,nhận].
nn("N'NV Xử Lý hàng hóa '") -->[nhân,viên,xử ,lý ,hàng ,hóa].
nn("N'NV phân hàng '") -->[nhân,viên,phân, hàng].
nn("N'%CTV%'") -->[cộng,tác,viên].
nn("N'%NV%'") -->[nhân,viên].
nn("N'nữ'")-->[nữ].
nn("N'nam'")-->[nam].
nn("N'xe số'")-->[xe,số].
nn("N'xe ga'")-->[xe,tay,ga].
nn("N'không có xe'")-->[không,có,xe].
nn(" DISTINCT ")-->[các,loại].
nn(" * ")-->[tất,cả,thông,tin];[tất,cả,các,thông,tin];[thông,tin].
nn(" 'datetime' ") -->[datetime].
nn(" N'specificname' ")-->[specificname].
nn(" max(Luongtoithieu) ") -->[lương,cao,nhất];[lương,yêu,cầu,cao,nhất];[lương,tối,thiểu,cao,nhất].
nn(" min(Luongtoithieu) ") -->[lương,thấp,nhất];[lương,yêu,cầu,thấp,nhất];[lương,tối,thiểu,thấp,nhất].
in(" From ")-->[của].
in(" Between ") -->[từ].
cc(" OR ")-->[hoặc];[hay].
cc(" AND ")-->[và];[đến];[-];[tới].
cc(" , ")-->[,].
jj(" = '' ") -->[không,rõ,ràng].
jj(" not ") -->[không,phải].
rb(" not ") -->[không].
cd(SEM)-->[X],
{
float(X),with_output_to(codes(S1),write(X)),append(S1,"",SEM);
integer(X),with_output_to(codes(S1),write(X)),append(S1,"",SEM)
}.
test(Term, String) :-
        with_output_to(char(String), write(Term)).

getcd(A,S):-nnp(B,A,[]),with_output_to(atom(S),writef(B,"%s")),!.
getquery(A,S):-s(B,A,[]),with_output_to(atom(S),writef(B,"%s")),!.

%getquery([cho,biết,tên,của,các,ứng,viên,có,năm,sinh,là,1997],S).


