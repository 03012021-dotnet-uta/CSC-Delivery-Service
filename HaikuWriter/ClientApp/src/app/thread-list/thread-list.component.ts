import { analyzeAndValidateNgModules } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { Thread } from '../models/thread.model';
import { ThreadService } from '../service/thread.service';

@Component({
  selector: 'app-thread-list',
  templateUrl: './thread-list.component.html',
  styleUrls: ['./thread-list.component.css']
})
export class ThreadListComponent implements OnInit {
  threads?: Thread[];
  threadlist?: Thread[];
  thread = new Thread(0, "  ", "  ");
  x = 0;
  listLength = 0;
  constructor(private router: Router,
    private route: ActivatedRoute,
    private threadservice: ThreadService) { }

  ngOnInit(): void {
    if(localStorage.getItem("User")== null){
      this.router.navigateByUrl('/login')
    }
    this.GetThreads();
  }
  
  onNext(){
    this.x++;
    this.threads = this.threadlist?.slice((this.x * 10), ((this.x * 10)+10))
  }
  onPrev(){
    this.x--;
    this.threads = this.threadlist?.slice((this.x * 10), ((this.x * 10)+10))
  }

  ThreadPage(threadid: number){

    localStorage.setItem('thread', threadid.toString());
    // console.log(threadid);
    this.router.navigateByUrl('/thread');
  }
  //connect to a service to connect to C# side.
  GetThreads() {
    this.threadservice.GetThreads().subscribe(
      res =>{
        
        this.threadlist = res
        this.listLength = this.threadlist.length;
        if(this.threadlist.length > 10){
          this.threads = this.threadlist.slice(0, 10);
        }else{
          this.threads = this.threadlist;
        }
        
        console.log(this.threads)
       }
       );                                                                                                                                                           
  }
  CreateThread(){
    this.thread.username = localStorage.getItem("User");
    this.PostThread();
  }
  
  PostThread(){
    this.threadservice.PostThread(this.thread).subscribe(res => {
      this.thread = res
      this.thread.threadId = res.threadId;
      this.ThreadPage(this.thread.threadId);
      const form = <HTMLFormElement>document.getElementById("createAThread");
      form.reset();
    });
  }

  logout(){
    localStorage.clear();
    this.router.navigateByUrl('/login')
  }
}
