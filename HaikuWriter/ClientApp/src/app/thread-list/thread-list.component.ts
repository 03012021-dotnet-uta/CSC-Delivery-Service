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
  thread!: Thread;
  constructor(private router: Router,
    private route: ActivatedRoute,
    private threadservice: ThreadService) { }

  ngOnInit(): void {
    this.GetThreads();
  }
  
  toLandingPage(){
    
    this.router.navigateByUrl('/landingpage');
  }
  ThreadPage(threadid: number){
    localStorage.setItem('thread', this.thread.threadid.toString());
    this.router.navigateByUrl('/thread');
  }
  //connect to a service to connect to C# side.
  GetThreads() {
    this.threadservice.GetThreads().subscribe(res => this.threads = res);                                                                                                                                                           
  }
  CreateThread(username: string, threaddesc: string){
    this.thread.description = threaddesc;
    this.thread.username = username;
    this.PostThread(this.thread);
    this.ThreadPage(this.thread.threadid);
  }
  PostThread(thread: Thread){
    this.threadservice.PostThread(this.thread).subscribe(res => this.thread = res);
    
  }
}
