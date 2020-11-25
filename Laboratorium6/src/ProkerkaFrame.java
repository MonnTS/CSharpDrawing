import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class ProkerkaFrame extends JFrame implements MouseListener, MouseWheelListener, MouseMotionListener {

    int prok = 0;
    int prok1 = 1;
    int prok2 = 5;
    JLabel label, label1, labelstatus, status, pressed;
    JCheckBox cb1, cb2, cb3, cb4, cb5;
    JTextField textField, textField1;
    JButton jButton;
    ImageIcon[] icons = new ImageIcon[]{
            new ImageIcon("C:\\Users\\Daniel\\IdeaProjects\\Laboratorium6\\img\\icon0.png"),
            new ImageIcon("C:\\Users\\Daniel\\IdeaProjects\\Laboratorium6\\img\\icon1.png"),
            new ImageIcon("C:\\Users\\Daniel\\IdeaProjects\\Laboratorium6\\img\\icon2.png"),
            new ImageIcon("C:\\Users\\Daniel\\IdeaProjects\\Laboratorium6\\img\\icon3.png"),
            new ImageIcon("C:\\Users\\Daniel\\IdeaProjects\\Laboratorium6\\img\\icon4.png"),
            new ImageIcon("C:\\Users\\Daniel\\IdeaProjects\\Laboratorium6\\img\\icon5.png"),
    };

    ProkerkaFrame() {
        cb1 = new JCheckBox("Click");
        cb1.setBounds(10, 350, 75, 15);
        cb2 = new JCheckBox("Pressed || Released");
        cb2.setBounds(10, 365, 200, 15);
        cb3 = new JCheckBox("Scrolling");
        cb3.setBounds(10, 380, 100, 15);
        cb4 = new JCheckBox("Moving");
        cb4.setBounds(10, 395, 100, 15);
        cb5 = new JCheckBox("Entered || Exited zone");
        cb5.setBounds(10, 410, 200, 15);

        textField = new JTextField("...");
        textField.setBounds(10, 200, 150, 18);
        textField.addMouseListener(this);

        textField1 = new JTextField("Hints are real!");
        textField1.setBounds(450, 444, 350, 18);
        textField1.addMouseMotionListener(this);

        label = new JLabel();
        label.addMouseListener(this);
        label.setIcon(icons[prok]);
        label.setBounds(10, 10, 150, 150);

        label1 = new JLabel();
        label1.addMouseWheelListener(this);
        label1.setIcon(icons[prok]);
        label1.setBounds(160, 10, 150, 150);

        pressed = new JLabel();
        pressed.setOpaque(true);
        pressed.setBackground(Color.GRAY);
        pressed.setBounds(310, 10, 470, 400);

        labelstatus = new JLabel();
        labelstatus.setOpaque(true);
        labelstatus.setBackground(Color.RED);
        labelstatus.setBounds(690, 425, 150,18);

        status = new JLabel("...");
        status.setBounds(5, 435, 300, 30);

        jButton = new JButton("Click me");
        jButton.setBounds(10, 220, 150, 25);
        jButton.setOpaque(true);

        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setSize(800, 500);
        this.setLayout(null);
        this.setLocationRelativeTo(null);
        this.setVisible(true);
        this.addMouseMotionListener(this);
        this.add(label);
        this.add(label1);
        this.add(labelstatus);
        this.add(status);
        this.add(pressed);
        this.add(cb1);
        this.add(cb2);
        this.add(cb3);
        this.add(cb4);
        this.add(cb5);
        this.add(textField);
        this.add(textField1);
        this.add(jButton);

        cb1.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseEntered(MouseEvent e) {
                textField1.setText("Click on the first image");
            }

            @Override
            public void mouseExited(MouseEvent e) {
                textField1.setText("Hints are real!");
            }
        });

        cb2.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseEntered(MouseEvent e) {
                textField1.setText("Press and then release the mouse on first image");
            }

            @Override
            public void mouseExited(MouseEvent e) {
                textField1.setText("Hints are real!");
            }
        });
        cb3.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseEntered(MouseEvent e) {
                textField1.setText("Try to scroll over the second image");
            }

            @Override
            public void mouseExited(MouseEvent e) {
                textField1.setText("Hints are real!");
            }
        });

        cb4.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseEntered(MouseEvent e) {
                textField1.setText("Moved the cursor");
            }

            @Override
            public void mouseExited(MouseEvent e) {
                textField1.setText("Hints are real!");
            }
        });

        cb5.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseEntered(MouseEvent e) {
                textField1.setText("Enter and then exit the area with your cursor");
            }

            @Override
            public void mouseExited(MouseEvent e) {
                textField1.setText("Hints are real!");
            }
        });

            jButton.addMouseListener(new MouseAdapter() {
                @Override
                public void mousePressed(MouseEvent e) {
                    if(cb2.isSelected()){
                        pressed.setBackground(new Color((int)(Math.random() * 256),
                                (int)(Math.random() * 256),(int)(Math.random() * 256)));
                        status.setText("You pressed the mouse!");
                        jButton.setText("You pressed me!");
                    }
                }
            });
    }
    
    @Override
    public void mouseClicked(MouseEvent e) {
        if(cb1.isSelected()){
            status.setText("You have clicked the image!");
            label.setIcon(icons[prok1]);
        }
    }

    @Override
    public void mousePressed(MouseEvent e) {
        // It's empty here...
    }

    @Override
    public void mouseReleased(MouseEvent e) {
        if(cb2.isSelected()){
            status.setText("You have released the mouse!");
            label.setIcon(icons[prok2]);
        }
    }

    @Override
    public void mouseEntered(MouseEvent e) {
        if(cb5.isSelected()){
            status.setText("The mouse has entered the text field!");
            textField.setText("Oh, hello there!");
        }
    }

    @Override
    public void mouseExited(MouseEvent e) {
        if(cb5.isSelected()){
            status.setText("The mouse has left the text field!");
            textField.setText("Goodbye then!");
        }
    }

    @Override
    public void mouseWheelMoved(MouseWheelEvent e) {
        if(cb3.isSelected()){
            if (e.getWheelRotation() == -1) {
                status.setText("You are scrolling up!");
                if(prok >= 0 && prok < 5)
                {
                    prok += 1;
                }
            } else {
                status.setText("You are scrolling down!");
                if(prok > 0)
                {
                    prok -= 1;
                }
            }
            label1.setIcon(icons[prok]);
        }
    }

    @Override
    public void mouseDragged(MouseEvent e) {
        // It's empty here...
    }

    @Override
    public void mouseMoved(MouseEvent e) {
        if(cb4.isSelected()){
            int x = e.getX();
            int y = e.getY();

            labelstatus.setText("Move:("+x+", "+y+")");
            status.setText("You are moving!");
        }
    }
}