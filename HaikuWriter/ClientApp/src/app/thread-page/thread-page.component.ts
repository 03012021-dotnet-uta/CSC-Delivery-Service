
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
  messageList?: Message[];
  message = new Message(0, '', '', 0);
  x = 0;
  mesLength = 0;
  constructor(private router: Router,
    private route: ActivatedRoute,
    private messageservice: MessageService) { }

  ngOnInit(): void {
    this.thread.threadId = Number(localStorage.getItem("thread"));
    console.log(localStorage.getItem("thread"))
    this.GetMessages(this.thread.threadId);
  }


  onNext(){
    this.x++;
    this.messages = this.messageList?.slice((this.x * 10), ((this.x * 10)+10))
  }
  onPrev(){
    this.x--;
    this.messages = this.messageList?.slice((this.x * 10), ((this.x * 10)+10))
  }

  CreateMessage(){
    this.message.threadId = this.thread.threadId;
    this.message.username = localStorage.getItem('User')
    this.PostMessage(this.message);
  }
  GetMessages(threadId: number){
    this.messageservice.GetMessages(threadId).subscribe(res => {
      this.messageList = res
      this.messages = this.messageList.slice(1, 10);
      this.mesLength= this.messageList.length;
      console.log(this.messages);
    });
  }

  PostMessage(message: Message){
    this.messageservice.PostMessage(this.message).subscribe(res => {
      this.messageList = res
      this.messages = this.messageList.slice(1, 10);
      this.mesLength= this.messageList.length;
      const form = <HTMLFormElement>document.getElementById("createAMethod");
      form.reset();
    }); 
  }

  logout(){
    localStorage.clear();
    this.router.navigateByUrl('/login')
  }
}
