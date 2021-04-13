
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
  thread = new Thread(Number(localStorage.getItem("thread")), " ", " ")
  messages?: Message[];
  message = new Message(0, '', '', 0);
  constructor(private router: Router,
    private route: ActivatedRoute,
    private messageservice: MessageService) { }

  ngOnInit(): void {
    this.thread.threadId = Number(localStorage.getItem("thread"));
    console.log(localStorage.getItem("thread"))
    this.GetMessages(this.thread.threadId);
  }
  toLandingPage(){
    this.router.navigateByUrl('/landingpage')
  }
  toForum(){
    this.router.navigateByUrl('/forum')
  }
  CreateMessage(){
    this.message.threadId = this.thread.threadId;
    this.message.username = localStorage.getItem('User')
    this.PostMessage(this.message);
  }
  GetMessages(threadId: number){
    this.messageservice.GetMessages(threadId).subscribe(res => this.messages = res);
  }

  PostMessage(message: Message){
    this.messageservice.PostMessage(this.message).subscribe(res => this.messages = res);
    
  }
}
