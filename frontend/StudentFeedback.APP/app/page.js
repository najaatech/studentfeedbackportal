"use client"

import Image from "next/image";
import styles from "./page.module.css";
import { submitFeedback } from "./api/feedbackApi";
import { useState } from "react";

export default function Home() {
  const [loading, setLoading] = useState(false);

  const handleTestSubmit = async () => {
    setLoading(true);
    try {
      await submitFeedback(
        {
          courseId: 2,
          rating: 5,
          comment: "Great course!",
        },
        1
      );
      alert("Feedback submitted successfully!");
    } catch (err) {
      alert("Error submitting feedback.");
    }
    setLoading(false);
  };

  return (
    <div className={styles.page}>
      <main className={styles.main}>
        <h1 className={styles.title}>Student Feedback Portal</h1>
        <button
          onClick={handleTestSubmit}
          disabled={loading}
          className={styles.button}
        >
          {loading ? "Submitting..." : "Send Test Feedback"}
        </button>

          <a
            href="https://localhost:7222/swagger"
            target="_blank"
            rel="noopener noreferrer"
            className={styles.button}
          >
            Swagger
          </a>
      </main>
    </div>
  );
}
