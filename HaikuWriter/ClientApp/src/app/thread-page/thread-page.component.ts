
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Message } from '../models/message.model';
import { Thread } from '../models/thread.model';
import { MessageService } from '../service/message.service';

@Component({
  selector: 'app-thread-page',
  templateUrl: './thread-page.component.html',
  styleUrls: ['./thread-page.component.css']
})
export class ThreadPageComponent implements OnInit {
  thread!: Thread;
  messages?: Message[];
  message!: Message;
  constructor(private router: Router,
    private route: ActivatedRoute,
    private messageservice: MessageService) { }

  ngOnInit(): void {
    this.GetMessages(this.thread.threadid);
  }
  toLandingPage(){
    this.router.navigateByUrl('/landingpage')
  }
  toForum(){
    this.router.navigateByUrl('/forum')
  }
  CreateMessage(){
    this.message.threadid = this.thread.threadid;
    this.message.username = localStorage.getItem('User')
    this.PostMessage(this.message);
  }
  GetMessages(threadid: number){
    this.messageservice.GetMessages(threadid).subscribe(res => this.messages = res);
  }

  PostMessage(message: Message){
    this.messageservice.PostMessage(this.message).subscribe(res => this.messages = res);
    
  }
}
