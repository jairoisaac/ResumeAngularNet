import { Component, OnInit } from '@angular/core';
import { ICertification } from './certification'
import { dataService } from '../shared/data.service';

@Component({
  selector: 'app-certifications',
  templateUrl: './certifications.component.html',
  styleUrls: ['./certifications.component.css']
})
export class CertificationsComponent implements OnInit {
  constructor(private CertificationService: dataService) { }
  errorMessage: string;
  //Certification: ICertification[] = [];
  Certification: string[] = [];
  imageWidth: number = 600;
  public myIndex = 0;
  public incrementmyIndex() {
   if (this.myIndex >= this.Certification.length - 1) { this.myIndex = 0; }
    this.myIndex++;
  }
  ngOnInit(): void {
    this.CertificationService.getCertifications().subscribe({
      next: certification => this.Certification = certification,
      error: err => this.errorMessage = err
    });
  }
}
