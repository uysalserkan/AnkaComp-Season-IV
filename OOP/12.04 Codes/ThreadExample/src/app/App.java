package app;

// * Miras yoluyla Thread oluşturmak.
class Worker1 extends Thread {
    @Override
    public void run() {
        loop1();
    }

    public void loop1() {
        for (int f = 0; f < 25; f++) {
            if(f==5){
                try {
                    Thread.sleep(10);
                } catch (Exception e) {
                    e.printStackTrace();
                }
            }
            System.out.println(
                    Thread.currentThread().getId() + ": " + Thread.currentThread().getName() + " = " + " " + f);
        }
    }
}

class Worker2 extends Thread {
    @Override
    public void run() {
        loop2();
    }

    public void loop2() {
        for (int f = 0; f < 25; f++) {
            System.out.println(
                    Thread.currentThread().getId() + ": " + Thread.currentThread().getName() + " = " + " " + f);
        }
    }
}

// * Interface yoluyla Thread oluşturmak
class Worker3 implements Runnable {
    @Override
    public void run() {
        loop3();
    }

    public void loop3() {
        for (int f = 0; f < 25; f++) {
            System.out.println(
                    Thread.currentThread().getId() + ": " + Thread.currentThread().getName() + " = " + " " + f);
        }
    }
}

public class App {
    public static void main(String[] args) {
        Worker1 w1 = new Worker1();
        Worker2 w2 = new Worker2();
        Thread tw1 = new Thread(new Worker3());
        w1.start();
        w2.start();
        tw1.start();
    }
}