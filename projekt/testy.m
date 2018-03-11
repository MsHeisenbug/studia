miasto = 'TORUÑ';
fid = fopen('s_d_t_01_2017.csv', 'rt');
x = zeros(1,31)
y = zeros(31)
i = 1;

while(~feof(fid))     
    out = regexp(fgetl(fid), ',', 'split');
    out = strrep(out, '"', '');
    
    if(contains(out(2),miasto))
        
        x(i) = out(5)
         out(10)
        i = i+1;
    end
end




fclose(fid);