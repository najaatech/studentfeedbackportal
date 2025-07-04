import axios from 'axios';

const API_BASE = 'https://localhost:7222';

export const submitFeedback = async (data, studentId) => {
  return axios.post(`${API_BASE}/api/Feedback`, data, {
    headers: {
      'x-user-role': 'Student',
      'x-student-id': studentId
    }
  });
};

export const getFeedbackReport = async () => {
  return axios.get(`${API_BASE}/api/report`, {
    headers: {
      'x-user-role': 'Admin'
    }
  });
};