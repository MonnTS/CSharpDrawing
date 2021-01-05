package pswbp.pl;

import org.eclipse.swt.SWT;
import org.eclipse.swt.widgets.*;

public class CalculatorFrame {

    public Display D;
    public Shell S;
    public Text Age;
    public Text Sex;
    public Text Pressure;
    public Text Mmol;
    public Text Mg;
    public final Label _mmol;
    public final Label _mgdl;
    public final Button Check;
    public final Button Check1;
    public final Button Smoking;
    public final Button NotSmoking;
    public final Button GetResult;
    public Checks prokerka;

    public CalculatorFrame()
    {
        D = new Display();
        S = new Shell(D);
        prokerka = new Checks(this);

        S.setSize(450,310);
        S.setText("Calculator of hysterectomies");
        S.open();

        Label _age = new Label(S, SWT.SINGLE);
        _age.setText("Age");
        _age.setBounds(10,10,50,20);

        Label _sex = new Label(S, SWT.SINGLE);
        _sex.setText("Sex");
        _sex.setBounds(10,60,50,20);

        Label _pressure = new Label(S, SWT.SINGLE);
        _pressure.setText("Pressure");
        _pressure.setBounds(10,115,50,20);

        _mmol = new Label(S, SWT.SINGLE);
        _mmol.setText("mmol/l");
        _mmol.setEnabled(false);
        _mmol.setBounds(10, 170, 50, 20);

        _mgdl = new Label(S, SWT.SINGLE);
        _mgdl.setText("mg/dl");
        _mgdl.setEnabled(false);
        _mgdl.setBounds(110, 170, 50, 20);

        Age = new Text(S, SWT.SINGLE | SWT.BORDER);
        Age.setBounds(10,35,90,20);

        Sex = new Text(S, SWT.SINGLE | SWT.BORDER);
        Sex.setBounds(10,85,90,20);

        Pressure = new Text(S, SWT.SINGLE | SWT.BORDER);
        Pressure.setBounds(10,140,90,20);

        Mmol = new Text(S, SWT.SINGLE | SWT.BORDER);
        Mmol.setEnabled(false);
        Mmol.setBounds(10, 195, 90, 20);

        Mg = new Text(S, SWT.SINGLE | SWT.BORDER);
        Mg.setEnabled(false);
        Mg.setBounds(110, 195, 90, 20);

        Check = new Button(S, SWT.CHECK);
        Check.setText("Calculate in mmol/l");
        Check.setBounds(10,220,130,20);

        Check1 = new Button(S, SWT.CHECK);
        Check1.setText("Calculate in mg/dl");
        Check1.setBounds(10,240,130,20);

        Smoking = new Button(S, SWT.CHECK);
        Smoking.setText("Smoking");
        Smoking.setBounds(150, 220, 90,20);

        NotSmoking = new Button(S, SWT.CHECK);
        NotSmoking.setText("Not Smoking");
        NotSmoking.setBounds(150, 240, 90,20);

        GetResult = new Button(S, SWT.PUSH);
        GetResult.setText("Get Result");
        GetResult.setBounds(340,235,80,30);
    }
}