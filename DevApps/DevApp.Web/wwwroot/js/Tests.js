

 
// ----------------------------------------------------------------------
class Tests {

    static Test() {
       
    }

    static async f() {
        return 1;
    }

    static async F2() {
        return new Promise((Resolve, Reject) => {
            setTimeout(Resolve(12345) , 2000);
        });
    }
}
 

tp.Ready(async function () {
 
    async function f() {
        return 1;
    }

    var x = await f();

    log(typeof x);
});